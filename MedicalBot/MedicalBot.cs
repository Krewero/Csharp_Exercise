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
            switch (patient.GetSymptoms())
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

            /*string GetDosage()
            {

            }*/
        }
    }
}