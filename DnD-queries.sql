select * from tblWeaps;
select * from tblStatMods;
select * from tblPlayerStats;
select * from tblplayerstats inner join tblstatmods on (tblplayerstats.pid=tblstatmods.pid);