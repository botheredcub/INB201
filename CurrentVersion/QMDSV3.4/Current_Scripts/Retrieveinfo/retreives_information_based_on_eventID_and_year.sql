select 
EventCode, Event_ID, EventStatus, latitude, longitude, 
CityName, Event_Date,  Event_updated_Date, user_ID,
 Phone, F_name, L_name
From 
events_t T inner join 
location L on T.CityName = L.CityName 
	inner join
	incidents I on T.Event_ID = I.Event_IDpersonnel
where events_t.CityName = location.CityName
	and events_t.EventID = incidents.EventID
	and incident.UserID = personnel.UserID
	and Event_Date > '2012-04-02' 