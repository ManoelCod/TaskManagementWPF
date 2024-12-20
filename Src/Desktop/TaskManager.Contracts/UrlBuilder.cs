﻿namespace TaskManager.Contracts
{
    using System.Linq;

    public static class UrlBuilder
    {
        public static string BaseUrl = "http://localhost:5013";

        public static string BuildEndponit(string controller) => $"{BaseUrl}/{controller}";

        public static string BuildEndpoint(string controller, int id) => $"{BaseUrl}/{controller}/{id}";

        public static string BuildEndpoint(string controller, string method) => $"{BaseUrl}/{controller}/{method}";

        public static string BuildEndpoint(string controller, string method, int id) => $"{BaseUrl}/{controller}/{method}/{id}";

        public static string BuildEndpoint(string controller, params string[] parameters)
            => BaseUrl + @"/" + controller + parameters.Aggregate(string.Empty, (current, next) => current + @"/" + next);
    }
}
