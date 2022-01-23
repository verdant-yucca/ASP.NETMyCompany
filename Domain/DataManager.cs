using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository)
        {
            TextFields = textFieldsRepository;
        }
    }
}
