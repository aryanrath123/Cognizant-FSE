SELECT registration_date, COUNT(DISTINCT user_id) AS user_count
FROM Registrations
WHERE registration_date >= CURDATE() - 7
GROUP BY registration_date
ORDER BY registration_date;