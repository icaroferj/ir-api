using IRCore.Util;
using IRCore.Util.Enumerator;
/// <summary>
/// Forces a secured (HTTPS) request to be resent over HTTP
/// </summary>
using System;
using System.Web.Mvc;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class OnlyHttpAttribute : FilterAttribute, IAuthorizationFilter
{
    public virtual void OnAuthorization(AuthorizationContext filterContext)
    {
        if (filterContext == null)
        {
            throw new ArgumentNullException("filterContext");
        }
        // Redireciona se urls que estiverem configurado
        if (!filterContext.HttpContext.Request.IsSecureConnection)
        {
            var urlDominioReplace = ConfiguracaoAppUtil.GetAsDictionary(enumConfiguracaoGeral.urlDominioReplace);
            foreach (var url in urlDominioReplace)
            {
                if ((filterContext.HttpContext.Request.Url.Host.Contains(url.Key)) && (!filterContext.HttpContext.Request.Url.Host.Contains(url.Value)))
                {
                    string urlWWW = "http://" + filterContext.HttpContext.Request.Url.Host.Replace(url.Key, url.Value) + filterContext.HttpContext.Request.RawUrl;
                    filterContext.Result = new RedirectResult(urlWWW);
                    return;
                }    
            }    
        }
        // Only redirect GET requests
        else if (string.Equals(filterContext.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
        {
            string url = "http://" + filterContext.HttpContext.Request.Url.Host + filterContext.HttpContext.Request.RawUrl;
            filterContext.Result = new RedirectResult(url);
        }
    }
}