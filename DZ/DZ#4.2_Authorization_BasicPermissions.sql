select * FROM common.Principal

--insert into Common.Principal (name) values ('DESKTOP-2MSS8AK\Marko')

select * FROM Common.Claim where ClaimResource = 'Hotels.Hotel' and ClaimRight = 'Read'

Select * FROM Common.Role
--INSERT INTO Common.Role (name) values ('HotelReader')

SELECT * FROM Common.RolePermission
--INSERT INTO Common.RolePermission (RoleID, ClaimID, IsAuthorized)
--SELECT r.ID, c.ID, 1 FROM
--Common.Role r 
--INNER JOIN Common.Claim c ON c.ClaimResource = 'Hotels.Hotel' and c.ClaimRight = 'Read'
--WHERE r.Name = 'HotelReader'

SELECT * FROM Common.PrincipalHasRole Where PrincipalID IN (SELECT ID FROM Common.Principal where Name = 'DESKTOP-2MSS8AK\Marko')
--INSERT INTO Common.PrincipalHasRole (PrincipalID, RoleID)
--SELECT p.ID, r.ID FROM
--Common.Principal p
--INNER JOIN Common.Role r ON r.Name = 'HotelReader'
--where p.Name = 'DESKTOP-2MSS8AK\Marko'