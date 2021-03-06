﻿//-----------------------------------------------------------------------
// <copyright file="SilverlightPrincipal.server.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using Csla.Security;
namespace Csla.Testing.Business.Security
{
  public partial class SilverlightPrincipal 
  {

    public static void LoginUsingCSLA(string name, string password)
    {
      var identity = CslaIdentity.GetCslaIdentity<SilverlightIdentity>(new Criteria(name, password));
      SetPrincipal(identity);
    }

    public static void Logout()
    {
      var identity = SilverlightIdentity.UnauthenticatedIdentity();
      SetPrincipal(identity);
    }
#if !CLIENTONLY
    public static void LoginUsingMembershipProviderDataPortal(string name, string password)
    {
      var identity = MembershipIdentity.GetMembershipIdentity<SilverlightMembershipIdentity>(name, password);
      SetPrincipal(identity);
    }

    public static void LoginUsingMembershipProviderWebServer(string name, string password)
    {
      SilverlightMembershipIdentity identity = MembershipIdentity.GetMembershipIdentity<SilverlightMembershipIdentity>(name, password);
      SetPrincipal(identity);
    }
#endif
  }
}