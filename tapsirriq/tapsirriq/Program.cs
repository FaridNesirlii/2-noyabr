//A.
//1.İçində başlanğıc olaraq[1, 2, 3, 4] dəyərlərini tutan array yaradın.
//2. Daha sonra döngüləri istifadə edərək bu arrayin elemanlarını ekrana yazdırın.
//3. Başqa bir döngüdə isə bu arrayin elemanlarinin her birinin üzərinə 1 əlavə edin.
//Example:
//Döngüdən əvvəl:
//[1,2,3,4]
//Döngüdən sonra:
//[2,3,4,5]
//int numArray= [ 21, 23, 12321, 312, 312, 312, 3, 14, 12, 4, 32, 53, 5, 234, 1, 32, 13, 12, 41,
//  321, 4, 124
// ];
//Console.WriteLine (numArray);
//---------------------------------------------------
int [] cars = { 1, 2,3, 4 };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i] +1);
}