
USE RetailStore;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Wireless Mouse', 'Electronics', 25.99),
(2, 'Mechanical Keyboard', 'Electronics', 89.99),
(3, 'Bluetooth Speaker', 'Electronics', 49.99),
(4, '4K Monitor', 'Electronics', 299.99),
(5, 'USB-C Hub', 'Electronics', 35.50),
(6, 'Office Chair', 'Furniture', 149.99),
(7, 'Standing Desk', 'Furniture', 399.99),
(8, 'Bookshelf', 'Furniture', 89.99),
(9, 'Desk Lamp', 'Furniture', 24.99),
(10, 'Filing Cabinet', 'Furniture', 119.99),
(11, 'Running Shoes', 'Footwear', 79.99),
(12, 'Leather Boots', 'Footwear', 129.99),
(13, 'Sandals', 'Footwear', 29.99),
(14, 'Wireless Earbuds', 'Electronics', 89.99);

-- Exercise 1: Ranking and Window Functions
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
    RANK()       OVER (PARTITION BY Category ORDER BY Price DESC) AS Rnk,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRnk
FROM Products
ORDER BY Category, Price DESC;
