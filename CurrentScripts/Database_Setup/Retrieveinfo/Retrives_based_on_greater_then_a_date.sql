select 
T.EventCode, T.Event_ID, T.EventStatus, L.latitude, L.longitude, 
T.CityName, T.Event_Date
From 
events_t T, 
location L 
where T.CityName = L.CityName
AND Event_date > '2012-02-03'
