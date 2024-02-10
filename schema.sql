
CREATE TABLE IF NOT EXISTS users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS category (
  category_id INT AUTO_INCREMENT PRIMARY KEY,
  category_name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS user_budget (
    budget_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    budget_amount FLOAT(7,2),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE IF NOT EXISTS expense_income ();


CREATE TABLE IF NOT EXISTS budget_line (
  expense_line INT AUTO_INCREMENT PRIMARY_KEY,
  category_id INT,
  year_id INT,
  month_id INT,
  expense_total FLOAT(7,2),
  FOREIGN KEY (category_id) REFERENCES category(category_id)
);
