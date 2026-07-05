SELECT event_id,
       AVG((end_time - start_time) * 24 * 60) AS average_duration
FROM Sessions
GROUP BY event_id;