namespace Application.Heplers
{

    /// <summary>
    /// Provides utility methods for managing and interacting with users in the system.
    /// </summary>
    /// <remarks>
    /// This helper class includes common operations for user management, such as retrieving users by ID or email,
    /// checking user existence, and interacting with user-related data in the database.
    /// It is designed to simplify user-related queries and encapsulate user management logic.
    /// </remarks>
    public class UserManagerHelper(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;


        /// <summary>
        /// Retrieves a user by their email address, including associated roles, 
        /// while ensuring the user is not soft-deleted or inactive.
        /// </summary>
        /// <param name="email">The email address of the user to find.</param>
        /// <returns>
        /// The <see cref="UserRole"/> object if found and valid; otherwise, <c>null</c>.
        /// </returns>
        internal async Task<User?> FindUserAsync(string email)
        {
            //return await _context.Users
            //    .Include(user => user.UserRoles)
            //        .ThenInclude(userRole => userRole.Role)
            //    .FirstOrDefaultAsync(user =>
            //        user.Email == email &&
            //        !user.DeletedDate.HasValue &&
            //        !user.Inactive);

            return default;
        }


        /// <summary>
        /// Retrieves a user by their unique identifier from the database.
        /// </summary>
        /// <param name="userId">The unique identifier of the user to retrieve.</param>
        /// <returns>
        /// The <see cref="UserRole"/> object if found; otherwise, <c>null</c>.
        /// </returns>
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }


        /// <summary>
        /// Retrieves a user by their email address from the database.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <returns>
        /// The <see cref="UserRole"/> object if found; otherwise, <c>null</c>.
        /// </returns>
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


        /// <summary>
        /// Checks if a user with the specified email address exists in the database.
        /// </summary>
        /// <param name="email">The email address to check for existence.</param>
        /// <returns>
        /// <c>true</c> if a user with the given email exists; otherwise, <c>false</c>.
        /// </returns>
        public async Task<bool> UserExistsAsync(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

    }
}
