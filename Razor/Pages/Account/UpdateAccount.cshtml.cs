using Domain.DTOs.AccountDTOs;
using Infrastructure.Services.AccountService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages.Account
{
    public class UpdateAccountModel : PageModel
    {
        private readonly IAccountService _accountService;

        public UpdateAccountModel(IAccountService AccountService)
        {
            _accountService = AccountService;
        }

        [BindProperty]
        public UpdateAccountDto Account { get; set; }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            Account.Id = id;
            await _accountService.UpdateAccountAsync(Account);

            return RedirectToPage("/Account/GetAccounts");
        }
    }
}
