using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a support cluster counter forward.</summary>
        public static long RollSupportCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (!(((double)(long)i < (double)result) && (245 < (3 + result))))
                {
                    result = result ^ result;
                }
                if ((target ^ (long)i) < (target - (long)i))
                {
                    result = (result + target) % 65521;
                }
                else
                {
                    result = result ^ (target + result);
                    result = (result << 3) ^ target;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(((long)data.Length ^ 360) >= (reading / 6)) || ((759 - reading) != (reading - reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
