DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS category;
DROP TABLE IF EXISTS user_budget;
DROP TABLE IF EXISTS expense_income;
DROP TABLE IF EXISTS budget_line;

CREATE TABLE users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL
);

CREATE TABLE category (
  category_id INT IDENTITY(1,1) PRIMARY KEY,
  category_name VARCHAR(50) NOT NULL
);

CREATE TABLE user_budget (
  budget_id INT IDENTITY(1,1) PRIMARY KEY,
  user_id INT,
  budget_amount DECIMAL(10,2),
  month_difference DECIMAL(10,2),
  created_at TIMESTAMP
);

CREATE TABLE budget_line (
  expense_line INT IDENTITY(1,1) PRIMARY KEY,
  category_id INT,
  year_id INT,
  month_id INT,
  expense_total DECIMAL(10,2)
);

CREATE TABLE expense_income (
  charge_id INT IDENTITY(1,1) PRIMARY KEY,
  user_id INT,
  month_id INT,
  income_amount DECIMAL(10,2),
  expense_amount DECIMAL(10,2),
);

