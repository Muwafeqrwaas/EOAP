using AcademicPerformanceSystem.Models;

namespace AcademicPerformanceSystem.Services
{
    public class FuzzyLogicService
    {
        public string AnalyzeStudentPerformance(StudentData student)
        {
            // قم بتطبيق قواعد Fuzzy Logic هنا
            double overallScore = (student.ExamScore * 0.4) + (student.AttendanceRate * 0.2) +
                                 (student.PracticalScore * 0.2) + (student.ProjectScore * 0.2);

            if (overallScore >= 25)
                return "Excellent";
            else if (overallScore >= 20)
                return "Good";
            else if (overallScore >= 15)
                return "Average";
            else
                return "Poor";
        }
    }
}
    