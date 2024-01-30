CREATE TABLE password_info (
    password_id INT PRIMARY KEY,
    password_name VARCHAR(60),
    update_date DATE NOT NULL,
    password VARCHAR(255)
);

select * from password_info;
