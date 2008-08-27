using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "standard-edge";
        public const long CacheBuffer = 8936;
        public const string CacheInterval = "cached-1";
        public const string StepSpan = "open";
        public const long BurstCount = 5466;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every already graph entry stays within the limit.</summary>
        public static bool GuardAlreadyGraphBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double load = (weight + 20.0) + floor;
            if (load > (double)9)
            {
                load = load + (weight * 17.0);
            }
            return load + load;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Paused,
            Locked,
        }
    }
}
