using System.Security.Cryptography.X509Certificates;
using Bot;

public class Patient
{
    private string _name;
    private int _age;
    private string _gender;
    private string _medicalHistory;
    private string _symptomCode;
    private string _prescription;

    public string GetName()
    {
        return this._name;
    }
    
    public void SetName(string name)
    {
        if(name != null|| name.Length > 2 )
        {
            this._name = name;
        }
        else
        {
            Console.WriteLine("Impossible to set this name");
        }
    }

    public int GetAge()
    {
        return this._age;
    }
    
    public void SetAge(int age)
    {
        if(age > 100)
        {
            Console.WriteLine("Impossible to set this age");
        }
        else
        {
            this._age = age;
        }
    }

    public string GetGender()
    {
        return this._gender;
    }

    public void SetGender(string gender)
    {
        if(gender == "Male" || gender == "Female" || gender == "Other")
        {
            this._gender = gender;
        }
        else
        {
            Console.WriteLine("Impossible to set this gender\nPlease choos: Male, Female or other");
        }
    }

    public string GetMedicalHistory()
    {
        return this._medicalHistory;
    }

    public void SetMedicalHistory(string medicalHistory)
    {
        this._medicalHistory = medicalHistory;
    }

    public void SetSymptomCode(string code)
    {
        if( code == "S1"|| code == "S2"|| code == "S3")
        {
            this._symptomCode = code;
        }
        else
        {
            Console.WriteLine("Impossible to set this code");
        }   
    }

    public string GetSymptoms()
    {
        switch(this._symptomCode)
        {
            case "S1":
            {
                this._symptomCode = "Headache";
                break;
            }
            case "S2":
            {
               this._symptomCode = "Skin rashes";
                break;
            }
            case "S3":
            {
                this._symptomCode = "Dizziness";
                break;
            }
            default:
            {
                this._symptomCode = null;
                break;
            }
        }
        return this._symptomCode;
    }

    public string GetSymptoms2()
    {
        return this._symptomCode;
    }

    public string GetPrescription()
    {
        return this._prescription;
    }

    public void SetPrescription(string prescription)
    {
        this._prescription = prescription;
    }
}