namespace Bot
{
    public class MedicalBot
    {
        public const string BotName = "Bob";


        public static string GetBotName()
        {
            return BotName;
        }
        public void PrescribeMedication(Patient patient)
        {
            switch (patient.GetSymptoms2())
            {
                case "Headache":
                    {
                        Console.WriteLine("Ibuprofen");
                        break;
                    }
                case "Skin rashes":
                    {
                        Console.WriteLine("Diphenhydramine");
                        break;
                    }
                case "Dizziness":
                    {
                        if (patient.GetMedicalHistory() == "Diabetes")
                        {
                            Console.WriteLine("Metformin");
                        }
                        else
                        {
                            Console.WriteLine("Dimenhydrinate");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Impossible to prescribe");
                        break;
                    }
            }

            string GetDosage(string medicineName)
            {
                switch(medicineName)
                {
                    case "ibuprofen":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription("The dosage is 400 mg");
                        }
                        else
                        {
                            patient.SetPrescription("The dosage is 800 mg");
                        }
                        break;
                    }
                    case "diphenhydramine":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription("The dosage is 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription("the dosage is 300 mg");
                        }
                        break;
                    }
                    case "dimenhydrinate":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription("The dosage is 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription("the dosage is 400 mg");
                        }
                        break;
                    }
                    case "Metformin":
                    {
                        Console.WriteLine("The dosage is 500 mg");
                        break;
                    }
                }
                return null;
            }
        }
    }
}