#roomTableAdapter
#Fill,GetData()
SELECT ID, roomName, description, floor, reservationID FROM rooms

#AddRoom(roomName, description, floor, reservationID)
INSERT INTO rooms
                  (roomName, description, floor, reservationID)
VALUES (?, ?, ?, NULL)
################################################################################################################################################
#floorsTableAdapter
#Fill,GetData()
SELECT ID, floorName FROM floors

#AddFloor(floorName)
INSERT INTO floors
                  (floorName)
VALUES (?)

#CheckAvailability(floorName)
SELECT COUNT(*) AS Unavailable
FROM     floors
WHERE  (floorName = ?)

#DeleteFloor(floorName)
DELETE FROM floors
WHERE  (floorName = ?)

#GetID(floorName)
SELECT ID
FROM     floors
WHERE  (floorName = ?)
################################################################################################################################################
#usersTableAdapter
#Fill,GetData()
SELECT ID, username, [password] FROM users

#getUserName(ID)
SELECT username
FROM     users
WHERE  (ID = ?)
################################################################################################################################################
#schedulesTableAdapter
#Fill, GetData()
SELECT ID, roomID, weekDay, startTime, endTime, purpose, Term, SY, subj, [section] 
FROM schedules

#AddSchedule(roomID, weekDay, startTime, endTime, purpose, Term, SY, subj, section)
INSERT INTO `schedules` (`roomID`, `weekDay`, `startTime`, `endTime`, `purpose`, `Term`, `SY`, `subj`, `section`) 
VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)

#CheckConflict(roomID, weekDay, startTime, endTime, purpose, Term, SY, subj, section)
SELECT COUNT(*) AS Expr1
FROM     schedules
WHERE  (roomID = ?) AND (weekDay = ?) AND (startTime <= ?) AND (endTime >= ?)

#DeleteSchedule(ID)
DELETE FROM schedules
WHERE  (ID = ?)
################################################################################################################################################
#reservationsTableAdapter
#Fill, GetData()
SELECT ID, reservee, admin, roomID, Purpose, term, sy, dateReserved, weekDay, startTime, endTime FROM reservations

#AddReservation(reservee, admin, roomID, Purpose, term, sy, dateReserved, weekDay, startTime, endTime)
INSERT INTO `reservations` (`reservee`, `admin`, `roomID`, `Purpose`, `term`, `sy`, `dateReserved`, `weekDay`, `startTime`, `endTime`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)

#CheckConflict(roomID, weekDay, startTime, endTime, purpose, Term, SY, subj, section)
SELECT COUNT(*) AS Expr1
FROM     reservations
WHERE  (roomID = ?) AND (dateReserved = ?) AND (startTime <= ?) AND (endTime >= ?)

#DeleteReservation(ID)
DELETE FROM reservations
WHERE  (ID = ?)
################################################################################################################################################