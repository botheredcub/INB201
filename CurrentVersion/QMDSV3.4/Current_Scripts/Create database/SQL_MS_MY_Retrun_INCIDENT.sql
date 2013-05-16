select 
T.EventCode, T.Event_ID, T.EventStatus, L.latitude, L.longitude, 
T.CityName, T.Event_Date, P.UserID, P.F_name, P.L_name, P.Phone
From 
events_t T, 
location L,
Incidents I,
Personnel P
where T.CityName = L.CityName
AND T.Event_ID = I.Event_ID
AND I.UserID = P.UserID
AND Event_date > '2012-02-03'
