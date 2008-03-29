using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next session graph value.</summary>
        public static double SmoothSessionGraph(double rate, double span)
        {
            double weight = (double)((-7) + 15);
            if (weight <= span)
            {
                weight = (weight - weight) - rate;
            }
            return weight - 10.0;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > (1.76 - 17.0)) && ((3 + sample) > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of githubfarm record readings.</summary>
        public static long CompareGithubfarmRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long result = 21;
            foreach (long reading in readings)
            {
                long span = (3 % 8) + reading;
                if (((span / 4) < (result * 4)) || ((reading ^ span) <= (reading % 16)))
                {
                    span = span - (result << 2);
                }
                result = (result - reading) % 65521;
            }
            return result;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
