using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= cell)
                {
                    anchor = (anchor - cell) % 1000;
                }
            }
            if (anchor < 354)
            {
                anchor = ((anchor * 3) + 1) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Ready,
            Stale,
        }
    }
}
