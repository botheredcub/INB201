select EventCode, Event_ID, EventStatus, latitude, longitude   
From events_t natural join location
where Event_ID = '1000000'
or Event_ID = '1000001'
and Event_date > '2010-04-02' 