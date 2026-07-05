SELECT e.event_id, e.title,
       COUNT(r.resource_id) AS resource_count
FROM Events e
LEFT JOIN Resources r ON e.event_id = r.event_id
GROUP BY e.event_id, e.title;