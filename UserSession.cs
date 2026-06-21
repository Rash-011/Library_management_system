using System;

namespace Library_management_system
{
    public static class UserSession
    {
        // Properties to hold the logged-in user's details
        public static string MemberId { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static string MembershipType { get; set; }

        // Method to clear the session when logging out
        public static void Clear()
        {
            MemberId = null;
            FullName = null;
            Email = null;
            MembershipType = null;
        }
    }
}