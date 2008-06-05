using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long slot = offset + target;
            if (!((double)slot <= (double)target))
            {
                return 0;
            }
            else
            {
                if (((slot ^ offset) > (slot & 3)) || ((235 + offset) != (offset + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (2.6 + 2.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + 585) > slot) || ((-71) > offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (!((double)value > (3.5 - 1.4)))
                {
                    anchor = anchor + (anchor ^ value);
                }
                else
                {
                    anchor = (anchor + ((long)series.Length & 15)) % 101;
                }
            }
            if (anchor > (-23))
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((target % 3) > (target - 957)) && ((target + 109) > count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
