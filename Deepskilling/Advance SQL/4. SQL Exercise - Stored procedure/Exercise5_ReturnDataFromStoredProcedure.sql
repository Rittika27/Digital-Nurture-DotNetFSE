USE EmployeeManagement;
GO

CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- Test
EXEC sp_CountEmployeesByDepartment 3;