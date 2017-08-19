//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(Sapling.Model.saplingEntities),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets2b245d8de0d7028f3e2b58c5e772bfa6c1fb70bf2c542fb412b7da3ed9249f1a))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySets2b245d8de0d7028f3e2b58c5e772bfa6c1fb70bf2c542fb412b7da3ed9249f1a : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "2b245d8de0d7028f3e2b58c5e772bfa6c1fb70bf2c542fb412b7da3ed9249f1a"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "saplingModelStoreContainer.Action")
            {
                return GetView0();
            }

            if (extentName == "saplingModelStoreContainer.Maintance")
            {
                return GetView1();
            }

            if (extentName == "saplingModelStoreContainer.Role")
            {
                return GetView2();
            }

            if (extentName == "saplingModelStoreContainer.Sapling")
            {
                return GetView3();
            }

            if (extentName == "saplingModelStoreContainer.Support")
            {
                return GetView4();
            }

            if (extentName == "saplingModelStoreContainer.Tree")
            {
                return GetView5();
            }

            if (extentName == "saplingModelStoreContainer.User")
            {
                return GetView6();
            }

            if (extentName == "saplingModelStoreContainer.UserClaim")
            {
                return GetView7();
            }

            if (extentName == "saplingModelStoreContainer.UserLogin")
            {
                return GetView8();
            }

            if (extentName == "saplingModelStoreContainer.UserRole")
            {
                return GetView9();
            }

            if (extentName == "saplingEntities.Action")
            {
                return GetView10();
            }

            if (extentName == "saplingEntities.Maintance")
            {
                return GetView11();
            }

            if (extentName == "saplingEntities.Role")
            {
                return GetView12();
            }

            if (extentName == "saplingEntities.Sapling")
            {
                return GetView13();
            }

            if (extentName == "saplingEntities.Support")
            {
                return GetView14();
            }

            if (extentName == "saplingEntities.Tree")
            {
                return GetView15();
            }

            if (extentName == "saplingEntities.User")
            {
                return GetView16();
            }

            if (extentName == "saplingEntities.UserClaim")
            {
                return GetView17();
            }

            if (extentName == "saplingEntities.UserLogin")
            {
                return GetView18();
            }

            if (extentName == "saplingEntities.UserRole")
            {
                return GetView19();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Action.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Action
        [saplingModel.Store.Action](T1.Action_Id, T1.Action_Name)
    FROM (
        SELECT 
            T.Id AS Action_Id, 
            T.Name AS Action_Name, 
            True AS _from0
        FROM saplingEntities.Action AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Maintance.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Maintance
        [saplingModel.Store.Maintance](T1.Maintance_Id, T1.Maintance_SaplingId, T1.Maintance_UserId, T1.Maintance_Date, T1.Maintance_ActionId, T1.Maintance_Description)
    FROM (
        SELECT 
            T.Id AS Maintance_Id, 
            T.SaplingId AS Maintance_SaplingId, 
            T.UserId AS Maintance_UserId, 
            T.Date AS Maintance_Date, 
            T.ActionId AS Maintance_ActionId, 
            T.Description AS Maintance_Description, 
            True AS _from0
        FROM saplingEntities.Maintance AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Role.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Role
        [saplingModel.Store.Role](T1.Role_Id, T1.Role_Name, T1.Role_IsActive)
    FROM (
        SELECT 
            T.Id AS Role_Id, 
            T.Name AS Role_Name, 
            T.IsActive AS Role_IsActive, 
            True AS _from0
        FROM saplingEntities.Role AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Sapling.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Sapling
        [saplingModel.Store.Sapling](T1.Sapling_Id, T1.Sapling_Location, T1.Sapling_UserId, T1.Sapling_Photo, T1.Sapling_IsExists, T1.Sapling_NextActionId, T1.Sapling_NextActionText, T1.Sapling_ReasonForNotExists, T1.Sapling_TreeId, T1.Sapling_NickName, T1.Sapling_Description, T1.Sapling_Address, T1.Sapling_CreatedBy, T1.Sapling_CreatedOn, T1.Sapling_ModifiedBy, T1.Sapling_ModifiedOn)
    FROM (
        SELECT 
            T.Id AS Sapling_Id, 
            T.Location AS Sapling_Location, 
            T.UserId AS Sapling_UserId, 
            T.Photo AS Sapling_Photo, 
            T.IsExists AS Sapling_IsExists, 
            T.NextActionId AS Sapling_NextActionId, 
            T.NextActionText AS Sapling_NextActionText, 
            T.ReasonForNotExists AS Sapling_ReasonForNotExists, 
            T.TreeId AS Sapling_TreeId, 
            T.NickName AS Sapling_NickName, 
            T.Description AS Sapling_Description, 
            T.Address AS Sapling_Address, 
            T.CreatedBy AS Sapling_CreatedBy, 
            T.CreatedOn AS Sapling_CreatedOn, 
            T.ModifiedBy AS Sapling_ModifiedBy, 
            T.ModifiedOn AS Sapling_ModifiedOn, 
            True AS _from0
        FROM saplingEntities.Sapling AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Support.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Support
        [saplingModel.Store.Support](T1.Support_Id, T1.Support_Text, T1.Support_SaplingId)
    FROM (
        SELECT 
            T.Id AS Support_Id, 
            T.Text AS Support_Text, 
            T.SaplingId AS Support_SaplingId, 
            True AS _from0
        FROM saplingEntities.Support AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.Tree.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Tree
        [saplingModel.Store.Tree](T1.Tree_Id, T1.Tree_Name, T1.Tree_History, T1.Tree_Maintain)
    FROM (
        SELECT 
            T.Id AS Tree_Id, 
            T.Name AS Tree_Name, 
            T.History AS Tree_History, 
            T.Maintain AS Tree_Maintain, 
            True AS _from0
        FROM saplingEntities.Tree AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.User.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User
        [saplingModel.Store.User](T1.User_Id, T1.User_UserName, T1.User_Password, T1.User_CreatedBy, T1.User_CreatedOn, T1.User_ModifiedBy, T1.User_ModifiedOn, T1.User_SecurityStamp, T1.User_EmailConfirmed, T1.User_IsVerficationEmailSent, T1.User_PhoneNumberConfirmed, T1.User_TwoFactorEnabled, T1.User_LockoutEnabled, T1.User_AccessFailedCount, T1.User_LockoutEndDateUtc, T1.User_UserActivationToken, T1.User_Email, T1.User_Mobile, T1.User_LastLoginDate)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.UserName AS User_UserName, 
            T.Password AS User_Password, 
            T.CreatedBy AS User_CreatedBy, 
            T.CreatedOn AS User_CreatedOn, 
            T.ModifiedBy AS User_ModifiedBy, 
            T.ModifiedOn AS User_ModifiedOn, 
            T.SecurityStamp AS User_SecurityStamp, 
            T.EmailConfirmed AS User_EmailConfirmed, 
            T.IsVerficationEmailSent AS User_IsVerficationEmailSent, 
            T.PhoneNumberConfirmed AS User_PhoneNumberConfirmed, 
            T.TwoFactorEnabled AS User_TwoFactorEnabled, 
            T.LockoutEnabled AS User_LockoutEnabled, 
            T.AccessFailedCount AS User_AccessFailedCount, 
            T.LockoutEndDateUtc AS User_LockoutEndDateUtc, 
            T.UserActivationToken AS User_UserActivationToken, 
            T.Email AS User_Email, 
            T.Mobile AS User_Mobile, 
            T.LastLoginDate AS User_LastLoginDate, 
            True AS _from0
        FROM saplingEntities.User AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.UserClaim.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserClaim
        [saplingModel.Store.UserClaim](T1.UserClaim_Id, T1.UserClaim_UserId, T1.UserClaim_ClaimType, T1.UserClaim_ClaimValue)
    FROM (
        SELECT 
            T.Id AS UserClaim_Id, 
            T.UserId AS UserClaim_UserId, 
            T.ClaimType AS UserClaim_ClaimType, 
            T.ClaimValue AS UserClaim_ClaimValue, 
            True AS _from0
        FROM saplingEntities.UserClaim AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.UserLogin.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserLogin
        [saplingModel.Store.UserLogin](T1.UserLogin_UserId, T1.UserLogin_LoginProvider, T1.UserLogin_ProviderKey)
    FROM (
        SELECT 
            T.UserId AS UserLogin_UserId, 
            T.LoginProvider AS UserLogin_LoginProvider, 
            T.ProviderKey AS UserLogin_ProviderKey, 
            True AS _from0
        FROM saplingEntities.UserLogin AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingModelStoreContainer.UserRole.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserRole
        [saplingModel.Store.UserRole](T1.UserRole_UserId, T1.UserRole_RoleId, T1.UserRole_IsActive)
    FROM (
        SELECT 
            T.UserId AS UserRole_UserId, 
            T.RoleId AS UserRole_RoleId, 
            T.IsActive AS UserRole_IsActive, 
            True AS _from0
        FROM saplingEntities.UserRole AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Action.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Action
        [saplingModel.Action](T1.Action_Id, T1.Action_Name)
    FROM (
        SELECT 
            T.Id AS Action_Id, 
            T.Name AS Action_Name, 
            True AS _from0
        FROM saplingModelStoreContainer.Action AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Maintance.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Maintance
        [saplingModel.Maintance](T1.Maintance_Id, T1.Maintance_SaplingId, T1.Maintance_UserId, T1.Maintance_Date, T1.Maintance_ActionId, T1.Maintance_Description)
    FROM (
        SELECT 
            T.Id AS Maintance_Id, 
            T.SaplingId AS Maintance_SaplingId, 
            T.UserId AS Maintance_UserId, 
            T.Date AS Maintance_Date, 
            T.ActionId AS Maintance_ActionId, 
            T.Description AS Maintance_Description, 
            True AS _from0
        FROM saplingModelStoreContainer.Maintance AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Role.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Role
        [saplingModel.Role](T1.Role_Id, T1.Role_Name, T1.Role_IsActive)
    FROM (
        SELECT 
            T.Id AS Role_Id, 
            T.Name AS Role_Name, 
            T.IsActive AS Role_IsActive, 
            True AS _from0
        FROM saplingModelStoreContainer.Role AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Sapling.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView13()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Sapling
        [saplingModel.Sapling](T1.Sapling_Id, T1.Sapling_Location, T1.Sapling_UserId, T1.Sapling_Photo, T1.Sapling_IsExists, T1.Sapling_NextActionId, T1.Sapling_NextActionText, T1.Sapling_ReasonForNotExists, T1.Sapling_TreeId, T1.Sapling_NickName, T1.Sapling_Description, T1.Sapling_Address, T1.Sapling_CreatedBy, T1.Sapling_CreatedOn, T1.Sapling_ModifiedBy, T1.Sapling_ModifiedOn)
    FROM (
        SELECT 
            T.Id AS Sapling_Id, 
            T.Location AS Sapling_Location, 
            T.UserId AS Sapling_UserId, 
            T.Photo AS Sapling_Photo, 
            T.IsExists AS Sapling_IsExists, 
            T.NextActionId AS Sapling_NextActionId, 
            T.NextActionText AS Sapling_NextActionText, 
            T.ReasonForNotExists AS Sapling_ReasonForNotExists, 
            T.TreeId AS Sapling_TreeId, 
            T.NickName AS Sapling_NickName, 
            T.Description AS Sapling_Description, 
            T.Address AS Sapling_Address, 
            T.CreatedBy AS Sapling_CreatedBy, 
            T.CreatedOn AS Sapling_CreatedOn, 
            T.ModifiedBy AS Sapling_ModifiedBy, 
            T.ModifiedOn AS Sapling_ModifiedOn, 
            True AS _from0
        FROM saplingModelStoreContainer.Sapling AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Support.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView14()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Support
        [saplingModel.Support](T1.Support_Id, T1.Support_Text, T1.Support_SaplingId)
    FROM (
        SELECT 
            T.Id AS Support_Id, 
            T.Text AS Support_Text, 
            T.SaplingId AS Support_SaplingId, 
            True AS _from0
        FROM saplingModelStoreContainer.Support AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.Tree.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView15()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Tree
        [saplingModel.Tree](T1.Tree_Id, T1.Tree_Name, T1.Tree_History, T1.Tree_Maintain)
    FROM (
        SELECT 
            T.Id AS Tree_Id, 
            T.Name AS Tree_Name, 
            T.History AS Tree_History, 
            T.Maintain AS Tree_Maintain, 
            True AS _from0
        FROM saplingModelStoreContainer.Tree AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.User.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView16()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing User
        [saplingModel.User](T1.User_Id, T1.User_UserName, T1.User_Password, T1.User_CreatedBy, T1.User_CreatedOn, T1.User_ModifiedBy, T1.User_ModifiedOn, T1.User_SecurityStamp, T1.User_EmailConfirmed, T1.User_IsVerficationEmailSent, T1.User_PhoneNumberConfirmed, T1.User_TwoFactorEnabled, T1.User_LockoutEnabled, T1.User_AccessFailedCount, T1.User_LockoutEndDateUtc, T1.User_UserActivationToken, T1.User_Email, T1.User_Mobile, T1.User_LastLoginDate)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.UserName AS User_UserName, 
            T.Password AS User_Password, 
            T.CreatedBy AS User_CreatedBy, 
            T.CreatedOn AS User_CreatedOn, 
            T.ModifiedBy AS User_ModifiedBy, 
            T.ModifiedOn AS User_ModifiedOn, 
            T.SecurityStamp AS User_SecurityStamp, 
            T.EmailConfirmed AS User_EmailConfirmed, 
            T.IsVerficationEmailSent AS User_IsVerficationEmailSent, 
            T.PhoneNumberConfirmed AS User_PhoneNumberConfirmed, 
            T.TwoFactorEnabled AS User_TwoFactorEnabled, 
            T.LockoutEnabled AS User_LockoutEnabled, 
            T.AccessFailedCount AS User_AccessFailedCount, 
            T.LockoutEndDateUtc AS User_LockoutEndDateUtc, 
            T.UserActivationToken AS User_UserActivationToken, 
            T.Email AS User_Email, 
            T.Mobile AS User_Mobile, 
            T.LastLoginDate AS User_LastLoginDate, 
            True AS _from0
        FROM saplingModelStoreContainer.User AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.UserClaim.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView17()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserClaim
        [saplingModel.UserClaim](T1.UserClaim_Id, T1.UserClaim_UserId, T1.UserClaim_ClaimType, T1.UserClaim_ClaimValue)
    FROM (
        SELECT 
            T.Id AS UserClaim_Id, 
            T.UserId AS UserClaim_UserId, 
            T.ClaimType AS UserClaim_ClaimType, 
            T.ClaimValue AS UserClaim_ClaimValue, 
            True AS _from0
        FROM saplingModelStoreContainer.UserClaim AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.UserLogin.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView18()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserLogin
        [saplingModel.UserLogin](T1.UserLogin_UserId, T1.UserLogin_LoginProvider, T1.UserLogin_ProviderKey)
    FROM (
        SELECT 
            T.UserId AS UserLogin_UserId, 
            T.LoginProvider AS UserLogin_LoginProvider, 
            T.ProviderKey AS UserLogin_ProviderKey, 
            True AS _from0
        FROM saplingModelStoreContainer.UserLogin AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for saplingEntities.UserRole.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView19()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UserRole
        [saplingModel.UserRole](T1.UserRole_UserId, T1.UserRole_RoleId, T1.UserRole_IsActive)
    FROM (
        SELECT 
            T.UserId AS UserRole_UserId, 
            T.RoleId AS UserRole_RoleId, 
            T.IsActive AS UserRole_IsActive, 
            True AS _from0
        FROM saplingModelStoreContainer.UserRole AS T
    ) AS T1");
        }
    }
}
