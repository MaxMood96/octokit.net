﻿using Octokit.Internal;

namespace Octokit
{
    public class AuthorizedKey
    {
        public AuthorizedKey()
        { }

        public AuthorizedKey(string key, string prettyPrint, string comment)
        {
            Key = key;
            PrettyPrint = prettyPrint;
            Comment = comment;
        }

        public string Key { get; private set; }

        [Parameter(Key="pretty-print")]
        public string PrettyPrint { get; private set; }

        public string Comment { get; private set; }
    }
}