﻿namespace DeploymentHelpers
{
    /// <summary>
    /// Result of a deployment.
    /// </summary>
    public class DeploymentResult
    {
        /// <summary>
        /// Base Uri of the deployment application.
        /// </summary>
        public string ApplicationBaseUri { get; set; }

        /// <summary>
        /// The web root folder where the application is hosted. This path can be different from the 
        /// original application source location if published before deployment.
        /// </summary>
        public string WebRootLocation { get; set; }

        /// <summary>
        /// Original deployment parameters used for this deployment.
        /// </summary>
        public DeploymentParameters DeploymentParameters { get; set; }
    }
}