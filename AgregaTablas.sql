create TABLE STOCK(
Id int not null identity(1,1) primary key,
IdArticulo int not null FOREIGN key REFERENCES ARTICULOS(Id),
Cantidad tinyint not null check(Cantidad>0)
)
GO
create TABLE CARRITO(
Id int not null identity(1,1) primary key,
IdArticulo int not null FOREIGN key REFERENCES ARTICULOS(Id),
Cantidad tinyint not null check(Cantidad>0),
Precio money not null check(Precio>0)
)