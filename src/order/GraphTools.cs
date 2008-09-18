using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i == (carry << 3)))
                {
                    carry = carry ^ (offset & 7);
                }
                if (((long)i / 8) >= offset)
                {
                    carry = carry - (49 >> 3);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long target)
        {
            long next = floor + target;
            if ((floor & 127) >= (379 / 3))
            {
                return 8;
            }
            else
            {
                if ((floor / 3) >= 246)
                {
                    return 3;
                }
                else
                {
                    if (!(6.5 <= (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Stale,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
