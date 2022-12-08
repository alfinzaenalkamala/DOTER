# DOTER
DOTER (Dodol Ternak) is an application that is used by the public to buy livestock for consumption directly from breeders without intermediaries. 
This application also displays the details of the animals being sold.


*This program uses C#, I changed the program that should use Springboot to ASP.NET API.
*For the implementation of SpringIoC, I changed it to Dependency Injection which can be seen in the Program.cs file.
*The implementation of javastream is like the LINQ command in .NET which can be seen in the file AnimalAppService.cs -> GetAllAnimal().

Alur Pengujian
->Breeder->Animal(required breederId)->Consumer->Purchase(required consumerId,breederId)->PuschaseDetail(required purchaseId,animalId )