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
                        Console.WriteLine(GetDosage("Ibuprofen"));
                        break;
                    }
                case "Skin rashes":
                    {
                        Console.WriteLine(GetDosage("Diphenhydramine"));
                        break;
                    }
                case "Dizziness":
                    {
                        if (patient.GetMedicalHistory() == "Diabetes")
                        {
                            Console.WriteLine(GetDosage("Metformin"));
                        }
                        else
                        {
                            Console.WriteLine(GetDosage("Dimenhydrinate"));
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(GetDosage("Impossible to prescribe"));
                        break;
                    }
            }

            string GetDosage(string medicineName)
            {
                switch(medicineName)
                {
                    case "Ibuprofen":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription(medicineName +"The dosage is 400 mg");
                        }
                        else
                        {
                            patient.SetPrescription(medicineName +"The dosage is 800 mg");
                        }
                        break;
                    }
                    case "Diphenhydramine":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription(medicineName +"The dosage is 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription(medicineName + "The dosage is 300 mg");
                        }
                        break;
                    }
                    case "Dimenhydrinate":
                    {
                        if(patient.GetAge() < 18)
                        {
                            patient.SetPrescription(medicineName +"The dosage is 50 mg");
                        }
                        else
                        {
                            patient.SetPrescription(medicineName +"The dosage is 400 mg");
                        }
                        break;
                    }
                    case "Metformin":
                    {
                        Console.WriteLine(medicineName +"The dosage is 500 mg");
                        break;
                    }
                }
                return patient.GetPrescription();
            }
        }
    }
}