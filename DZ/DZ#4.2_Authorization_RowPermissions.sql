--Moj user je Manage hotelima koji imaju u sebi Hotel1
select * FROM Hotels.Hotel
--UPDATE Hotels.Hotel SET Manager = SYSTEM_USER WHERE Name LiKE 'Hotel1%'

select * FROM Hotels.Room

--Dodavanje jedne sobe hotelu na koji moj USER nema pravo menagiranja
--INSERT INTO Hotels.Room (HotelID, RoomKindID, RoomNumber, Remark)
--SELECT h.ID, '9BAAEC1B-EE13-4EAE-BF6B-34B2CE46E9DF', '002', 'Hotel2'
--FROM Hotels.Hotel h
--WHERE h.Name = 'Hotel2'

--Dodavanje svih Basic Permissiona mojem USERu
SELECT * FROM Common.Principal
SELECT * FROM Common.PrincipalPermission
--INSERT INTO Common.PrincipalPermission (PrincipalID, ClaimID, IsAuthorized)
--SELECT (SELECT ID FROM Common.Principal WHERE Name = SYSTEM_USER), ID, 1 FROM Common.Claim


--Postman
----Test1 - soba iz Hotel1 se uspješno UPDATE
----Test2 - soba iz Hotel 2 za poslanu ovu izmjenu:
--{ "HotelID": "801BE8BB-CAA2-4000-94A8-B3A67193FD66", "RoomKindID": "9BAAEC1B-EE13-4EAE-BF6B-34B2CE46E9DF", "RoomNumber": "002", "Remark": "Hotel2: Test izmjene 2" }
----vraæa ovu poruku:
--{
--    "SystemMessage": "DataStructure:Hotels.Room,Property:RoomNumber",
--    "UserMessage": "It is not allowed to enter a duplicate record."
--}


SELECT * FROM Hotels.Guest 
--INSERT INTO Hotels.Guest (Name, Surname, Phone, Email) VALUES ('Name1', 'Surname1', 'Phone1', 'Email1')

--Dodavanje rezervacije na koju moj user nema pravo
--INSERT INTO Hotels.Reservation (DateFrom, DateTo, GuestID, RoomID) VALUES ('2019-03-13', '2019-03-20', '73A58F84-6A53-41A3-B2B2-537D12D8075E', '73434F43-D2E4-44FA-8494-D00600298C77')
--Upit: http://localhost/HotelsRhetosServer/rest/Hotels/reservation/ više ne prolazi veæ se javlja poruka: {"SystemMessage":"DataStructure:Hotels.Reservation.","UserMessage":"You are not authorized to access some or all of the data requested."}
--Ovo ide: http://localhost/HotelsRhetosServer/rest/Hotels/reservation/?filters=[{%22Filter%22:%22Common.RowPermissionsReadItems%22}]