   using Microsoft.AspNetCore.Components.Authorization;
   using System.Security.Claims;
   using System.Threading.Tasks;


   public class CustomAuthenticationStateProvider : AuthenticationStateProvider
   {
       public override Task<AuthenticationState> GetAuthenticationStateAsync()
       {
        
           // Replace with your actual logic to get the user information
           var identity = new ClaimsIdentity(new[]
           {
               new Claim(ClaimTypes.Name, "username")
           }, "testAuthType");

           var user = new ClaimsPrincipal(identity);
           return Task.FromResult(new AuthenticationState(user));
       }

       public void NotifyUserAuthentication(ClaimsPrincipal user)
       {
           NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
       }

       public void NotifyUserLogout()
       {
           var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
           NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymousUser)));
       }
   }
   