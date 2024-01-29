using System;
using System.Data;
using Bot;

public class Program
{
    static void Main(string[] args)
    {
        MedicalBot bob = new MedicalBot();

        Console.WriteLine("Hi, i'm Bob. I'm here to help you in your medication");
        Patient pat1 = new Patient();

        Console.WriteLine("Enter your details:");

        /*do
        {
            Console.WriteLine("Patient name:");
            string patientName = Console.ReadLine();
            pat1.SetName(patientName);
        }
        while (pat1.GetName() == null);

        do
        {
            Console.WriteLine("Patient age:");
            int age = Convert.ToInt32(Console.ReadLine());
            pat1.SetAge(age);
        }
        while (pat1.GetAge() == 0);

        do
        {
            Console.WriteLine("Patient Gender:");
            string gender = Console.ReadLine();
            pat1.SetGender(gender);
        }
        while (pat1.GetGender() == null);


        Console.WriteLine("Patient medical history:");
        string history = Console.ReadLine();
        pat1.SetMedicalHistory(history);*/
        

        do
        {
            Console.WriteLine("Which of the following symptoms do you have:\nS1.Headache\nS2.Skin rashes\nS3.Dizziness");
            string symptoms = Console.ReadLine();
            pat1.SetSymptomCode(symptoms);
        }
        while (pat1.GetSymptoms() == null);

        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        bob.PrescribeMedication(pat1);
        Console.WriteLine(pat1.GetPrescription());

        Console.WriteLine("Thank you for coming!");
    }
}