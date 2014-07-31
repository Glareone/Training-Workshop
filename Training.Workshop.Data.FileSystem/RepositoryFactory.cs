namespace Training.Workshop.Data.FileSystem
{
    public class RepositoryFactory : IRepositoryFactory
    {
        /// <summary>
        /// Gets user repository
        /// </summary>
        /// <returns></returns>
        public IUserRepository GetUserRepository()
        {
            return new UserRepository();
        }
    }
}
