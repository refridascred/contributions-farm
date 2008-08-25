using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long anchor = 95;
            foreach (long reading in values)
            {
                anchor = anchor ^ (94 % 2);
                if ((double)anchor != (6.0 - 6.54))
                {
                    break;
                }
                if ((anchor % 3) >= 88)
                {
                    anchor = (anchor << 2) ^ (anchor - anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (-969)) % 255;
                }
                if ((anchor >= (anchor + reading)) && ((anchor * 5) <= (anchor % 5)))
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Count cache farm pairs that satisfy a relation.</summary>
        public static long MatchCacheFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (result + result)) % 4096;
                result = ((result * 5) + ((long)i - (long)i)) % 1000;
                result = (result + (result >> 4)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
