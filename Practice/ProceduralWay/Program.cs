using System.Collections.Generic;

namespace ProceduralWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExtensionProcedural();

            //RunExtensionFunctional01();

            RunExtensionFunctional02();
        }


        private static void RunExtensionProcedural()
        {
            var q1 = ExtensionProcedural.GetEmployeesWithFirstNameStartsWith("ma");
            ExtensionProcedural.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtensionProcedural.GetEmployeesWithLastNameStartsWith("ju");
            ExtensionProcedural.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtensionProcedural.GetEmployeesWithDepartmentEqualsTo("hr");
            ExtensionProcedural.Print(q3, "Employees in 'HR' department");

            var q4 = ExtensionProcedural.GetEmployeesByGender("female");
            ExtensionProcedural.Print(q4, "Female employees");

            var q5 = ExtensionProcedural.GetEmployeesHiredInYear(2018);
            ExtensionProcedural.Print(q5, "Employees hired in '2018'");

            var q6 = ExtensionProcedural.GetEmployeesWithPensionPlanValueEqualsTo(true);
            ExtensionProcedural.Print(q6, "Employees with Pension Plan");

            var q7 = ExtensionProcedural.GetEmployeesWithHealthInsuranceValueEqualsTo(false);
            ExtensionProcedural.Print(q7, "Employees without Health insurance");

            var q8 = ExtensionProcedural.GetEmployeesWithSalaryEqualsTo(103200);
            ExtensionProcedural.Print(q8, "Employees with Salary = $103200");

            var q9 = ExtensionProcedural.GetEmployeesWithSalaryGreaterThan(107000);
            ExtensionProcedural.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtensionProcedural.GetEmployeesWithSalaryLessThan(107000);
            ExtensionProcedural.Print(q10, "Employees with Salary < $107000");

        }


        private static void RunExtensionFunctional01()
        {
            var listOfEmployees = Repository.LoadEmployees();
            var q1 = ExtensionFunctional01.Filter(listOfEmployees, e => e.FirstName.ToLowerInvariant().StartsWith( "ma"));
            ExtensionFunctional01.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtensionFunctional01.Filter(listOfEmployees, e => e.LastName.ToLowerInvariant().StartsWith( "ju"));
            ExtensionFunctional01.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Department.ToLowerInvariant() == "hr");
            ExtensionFunctional01.Print(q3, "Employees in 'HR' department");

            var q4 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Gender.ToLowerInvariant() == "female");
            ExtensionFunctional01.Print(q4, "Female employees");

            var q5 = ExtensionFunctional01.Filter(listOfEmployees, e => e.HireDate.Year == 2018);
            ExtensionFunctional01.Print(q5, "Employees hired in '2018'");

            var q6 = ExtensionFunctional01.Filter(listOfEmployees, e => e.HasPensionPlan);
            ExtensionFunctional01.Print(q6, "Employees with Pension Plan");

            var q7 = ExtensionFunctional01.Filter(listOfEmployees, e => !e.HasHealthInsurance);
            ExtensionFunctional01.Print(q7, "Employees without Health insurance");

            var q8 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Salary == 107000);
            ExtensionFunctional01.Print(q8, "Employees with Salary = $107000");

            var q9 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Salary > 107000);
            ExtensionFunctional01.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Salary < 107000);
            ExtensionFunctional01.Print(q10, "Employees with Salary < $107000");

            var q11 = ExtensionFunctional01.Filter(listOfEmployees, e => e.Salary < 107000 && e.Gender == "female");
            ExtensionFunctional01.Print(q11, "Employees with Salary < $107000 and female");


        }


        private static void RunExtensionFunctional02()
        {
            var listOfEmployees = Repository.LoadEmployees();

            var q1 = listOfEmployees.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            q1.Print("Employees with first name starts with 'ma'");

            var q2 = listOfEmployees.Filter(e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            q2.Print("Employees with last name starts with 'ju'");

            var q3 = listOfEmployees.Filter(e => e.Department.ToLowerInvariant() == "hr");
            q3.Print("Employees in 'HR' department");

            var q4 = listOfEmployees.Filter( e => e.Gender.ToLowerInvariant() == "female");
            q4.Print("Female employees");

            var q5 = listOfEmployees.Filter( e => e.HireDate.Year == 2018);
            q5.Print("Employees hired in '2018'");

            var q6 = listOfEmployees.Filter(e => e.HasPensionPlan);
            q6.Print("Employees with Pension Plan");

            var q7 = listOfEmployees.Filter( e => !e.HasHealthInsurance);
            q7.Print("Employees without Health insurance");

            var q8 = listOfEmployees.Filter( e => e.Salary == 107000);
            q8.Print("Employees with Salary = $107000");

            var q9 = listOfEmployees.Filter( e => e.Salary > 107000);
            q9.Print("Employees with Salary > $107000");

            var q10 = listOfEmployees.Filter(e => e.Salary < 107000);
            q10.Print("Employees with Salary < $107000");

            var q11 = listOfEmployees.Filter( e => e.Salary < 107000 && e.Gender == "female");
            q11.Print("Employees with Salary < $107000 and female");

        }

    }

}
