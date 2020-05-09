This article overview FileResult in ASP.Net Core MVC. The FileResult actions used to read and write files. FileResult is the parent of all file related action results. There is a method on ControllerBase class called File. This method accept a set of parameters based on the type of file and its location, which maps directly to the more specific return types
FileResult

FileResult is the parent of all file related action results. It is a base class that is used to send binary file content to the response. It represents an ActionResult that when executed will write a file as the response

FileContentResult

FileContentResult is an ActionResult that when executed will write a binary file to the response. 

FileStreamResult

FileStreamResult Sends binary content to the response by using a Stream instance. When we want to return the file as a FileStream.

VirtualFileResult

A FileResult that on execution writes the file specified using a virtual path to the response using mechanisms provided by the host. You can use VirtualFileResult if you want to read a file form a virtual address and return it.

PhysicalFileResult

A FileResult on execution will write a file from disk to the response using mechanisms provided by the host.You can use PhysicalFileResult to read a file from a physical address and return it, as shown in PhysicalFileResult method
