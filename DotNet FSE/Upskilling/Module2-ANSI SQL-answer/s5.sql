SELECT u.city, COUNT(DISTINCT u.user_id) AS user_registrations
FROM Users u
JOIN Registrations r ON u.user_id = r.user_id
GROUP BY u.city
ORDER BY user_registrations DESC
LIMIT 5;