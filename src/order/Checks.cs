using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Draft,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((result + step) <= result)
                {
                    break;
                }
                else
                {
                    result = result + ((-28) + step);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 3) >= (count - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
