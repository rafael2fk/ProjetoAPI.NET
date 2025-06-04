using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using System.Globalization;

namespace MyRecipeBook.Application.UserCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisterdUserJson Execute(RequestRegisterUserJson request)
        {
            Validate(request);

            return new ResponseRegisterdUserJson
            {
                Name = request.Name,
            };
        }

        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();

            }
        }

    }
}
