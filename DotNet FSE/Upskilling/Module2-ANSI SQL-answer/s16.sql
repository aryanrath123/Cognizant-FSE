SELECT u.*
FROM Users u
LEFT JOIN Registrations r ON u.user_id = r.user_id
WHERE u.registration_date >= CURRENT_DATE - 30
AND r.user_id IS NULL;