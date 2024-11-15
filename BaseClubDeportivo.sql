drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
Activo boolean default true,
constraint pk_usuario primary key (CodUsu)
);

insert into usuario(NombreUsu,PassUsu) values
('admin','123456');

create table socio(
nroSocio int auto_increment,
nombre varchar(50),
apellido varchar(50),
genero varchar(50),
edad int,
dni int,
tipo int,
constraint pk_socio primary key(nroSocio)
);

create table carnet(
	nroCarnet int auto_increment,
    fechaEmision date,
    fechaVencimiento date,
    nroSocio int,
    constraint pk_carnet primary key (nroCarnet),
    constraint fk_socio foreign key (nroSocio) references socio(nroSocio)
);

create table recibo(
	nroRecibo int auto_increment,
    emision datetime,
    monto float,
    nroSocio int,
    constraint pk_recibo primary key (nroRecibo),
    constraint fk_socio_recibo foreign key (nroSocio) references socio(nroSocio)
);

delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
begin
  
  select CodUsu
	from usuario
		where NombreUsu = Usu and PassUsu = Pass
			and Activo = 1;


end 
//

call IngresoLogin('admin', '123456')//

create procedure NuevoSocio(in Nom varchar(50),in Ape varchar(50),in Gen varchar(50), in Edad int, in Doc int, in Tipo int,  out rta int)
begin
	declare filas int default 0;
	declare existe int default 0;

	set filas = (select count(*) from socio);
	if filas = 0 then
	set filas = 452;
	set filas = (select max(nroSocio) + 1 from socio);	
	set existe = (select count(*) from socio where dni = Doc);
	end if;

	if existe = 0 then	 
	 insert into socio values(filas,Nom,Ape,Gen,Edad,Doc,Tipo);
	 set rta  = filas;
	else
	 set rta = existe;
	end if;		 
    
end //

create procedure NuevoCarnet(in nSocio int, out rta int)
begin
	declare filas int default 0;
	declare existe int default 0;
    
	set filas = (select count(*) from carnet);
	if filas = 0 then
		set filas = 100;
	else
		set filas = (select max(nroCarnet) + 1 from carnet);
        set existe = (select count(*) from carnet where nroSocio = nSocio);
     end if;
     if existe = 0 then	 
		 insert into carnet values(filas,now(),null,nSocio);
         update socio set tipo=1 where nroSocio=nSocio;
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;
end //

create procedure PagarCuota(in nSocio int, in Cant float, out rta int)
begin
	declare filas int default 0;
	declare resultado int default 0;
    declare fecha date default null;
    
	set filas = (select count(*) from carnet where nroSocio=nSocio);
	if filas = 0 then
		insert into recibo (emision, monto, nroSocio) values (now(), Cant, nSocio);
		set resultado = 1;
	else
		select fechaVencimiento from carnet where nroSocio=nSocio into fecha;
		if fecha is null or fecha < now() then
			update carnet set fechaVencimiento=DATE_ADD(now(), INTERVAL 1 MONTH) where nroSocio=nSocio;
            insert into recibo (emision, monto, nroSocio) values (now(), Cant, nSocio);
            set resultado = 3;
		else
			set resultado = 2;
		end if;
     end if;
     set rta = resultado;		
end //