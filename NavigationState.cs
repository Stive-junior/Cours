using System;

namespace ICT4D;

public class NavigationState
{

    public String? Pagecourante {get;set;}
    public string? PagePrecedente{get;set;}

    public void SetCourantPage(String page){
        
        PagePrecedente = Pagecourante;
        Pagecourante = page;
    }



}
