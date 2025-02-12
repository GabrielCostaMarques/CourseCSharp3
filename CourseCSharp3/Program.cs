using CourseCSharp3.CarRental;
using CourseCSharp3.DirectoryExec;
using CourseCSharp3.FileInfoFile;
using CourseCSharp3.FilesStream;
using CourseCSharp3.PathUser;
using CourseCSharp3.StreamWriterExec;

internal class Program
{
    public static void Main(string[] args)
    {
        CarRentalUser user = new CarRentalUser();
        user.CarRentalShow();
    }
}