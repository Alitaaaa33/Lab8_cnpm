select * from UserLogin
insert into UserLogin values('User1','Le Khai','123',1)
insert into UserLogin values('User2','Hoang Anh','456',1)

select * from Item
insert into Item values('item1','Ao thun','X')
insert into Item values('item2','Ao hoodie','S')
insert into Item values('item3','Ao dai tay','XL')
insert into Item values('item4','Quan jean','XLL')
insert into Item values('item5','Quan kaki','M')

select * from Agent
insert into Agent values('agent1','Ky Duyen','123 Ngo Gia Tu')
insert into Agent values('agent2','Mac Le','179 Nguyen Huu Tho')
insert into Agent values('agent3','Hoang Phuc','21 Hai Ba Trung')
insert into Agent values('agent4','Chi Pu','98 Lam Van Ben')
insert into Agent values('agent5','Nguyen Tung','41/12 Mai Van Vinh')


select * from Orderr
insert into Orderr values('oder1','12-2-2022','agent1')
insert into Orderr values('oder2','12-5-2022','agent2')
insert into Orderr values('oder3','12-8-2022','agent3')
insert into Orderr values('oder4','11-1-2022','agent4')
insert into Orderr values('oder5','20-8-2022','agent5')

select * from OrderDetail
insert into OrderDetail values('ordetail1','oder1','item1','1','5')
insert into OrderDetail values('ordetail2','oder2','item2','1','8')
insert into OrderDetail values('ordetail3','oder3','item3','2','2')
insert into OrderDetail values('ordetail4','oder4','item4','3','9')
insert into OrderDetail values('ordetail5','oder5','item5','1','1')

select * from dbo.UserLogin
select * from OrderDetail
select * from Orderr
select * from Agent
select * from Item