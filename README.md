# Flowerstore-final

this is the final project of flowerstore built using asp.net mvc and api


sql code->


create database dbFlowerStore;

use dbFlowerStore;


create table Customer(
id int identity(101,1) primary key,
name varchar(50) not null,
email varchar(150),
phone varchar(15),
address varchar(500),
vendor varchar(20) default 'User',
)
alter table customer add password varchar(50) not null

create table Flowers(
id int identity(1,1) constraint pk_flower_id primary key,
name varchar(50),
occassion varchar(50),
available_Quantity int,
unitPrice float check(unitPrice>=0),
fl_image varbinary(max)
) 


create table Cart(
Cart_ID  int identity(200,1) primary key,
Customer_ID int references Customer(id),
flower_id int references Flowers(id),
quantity int,
item_price float,
)

ALTER TABLE Cart ADD CONSTRAINT cons_cart_status DEFAULT 'Pending' FOR status


create table orderDetails(
order_id int identity(1,1) primary key,
flower_id int references Flowers(id),
customer_id int references Customer(id),
cart_id int references Cart(cart_ID),
totalprice float,
remark varchar(50),
payment_status varchar(20) default 'Pending'
)

Create table occasion(
occ_id int primary key,
occ_details varchar(50) 
)

insert into occasion values(1, 'Birthday'), (2, 'Anniversary'), (3, 'Love n Romance'), (4, 'Congratulations'), (5,  'I am sorry');
insert into occasion values(6, 'Thinking of you'), (7, 'House Warming'), (8, 'Thank you'), (9, 'Miss you'), (10,  'Get well soon');
insert into occasion values(11, 'Sympathy n Funeral');
