drop schema if exists DnD;
create schema if not exists DnD;
use DnD;
drop table if exists tblPlayerStats;
drop table if exists tblWeaps;

#tblWeaps
create table if not exists tblWeaps (
wID int(5) primary key,
wWgt int(3),
wArmBonus int(3),
wChkMod int(3),
wPrice text(5),
wName text(30));

#tblPlayerStats
create table if not exists tblPlayerStats (
pID int(5) primary key,
pSTR int(5),
pDEX int(5),
pCON int(5),
pINT int(5),
pWIS int(5),
pCHA int(5),
pHealth int(5),
pAC int(5),
pMoney text(20),
pInitiative int(5),
pPerception int(5),
pActionPoints int(5),
pClass text(10),
pRace text(10),
pGender text(1),
pAlign text(10),
pName text(30),
pColor text(1),
wID int(5),
pLevel int(3),
pExp int(10),
pCharLoc text(10),
modSTR int(2),
modDEX int(2),
modCON int(2),
modINT int(2),
modWIS int(2),
modCHA int(2),
constraint foreign key (wID) references tblWeaps(wID) on delete cascade on update cascade);

#datums
insert into tblWeaps values (1,0,0,0,"5g","Unarmed");

insert into tblPlayerStats values (8,14,15,10,14,7,13,22,12,"100g",11,10,9,"Warlord","Half Elf","F","Neutral Evil","Lthondre","R",1,10,0,"0,0",0,0,0,0,0,0);
insert into tblPlayerStats values (10,11,12,12,11,9,10,26,12,"100g",11,10,9,"Rogue","Gnome","M","Chaotic Good","Johannus BearFreakin","R",0,1,0,"0,0",1,1,1,1,1,1);

