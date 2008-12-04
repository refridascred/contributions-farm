using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Dropped,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((2.1 - 0.55) < (double)reading) && (((tally + reading) >= (reading + reading)) && ((2.0 - 7.01) == (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] values)
        {
            long score = 203;
            foreach (long entry in values)
            {
                score = score - (entry ^ entry);
                score = (score - (score ^ entry)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long step, long floor)
        {
            long lane = step ^ floor;
            if (((floor >> 4) <= step) || ((floor % 64) < (step + step)))
            {
                return 6;
            }
            else
            {
                if (((69 & 15) < step) && ((double)floor > (double)lane))
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) != (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((11.0 + 4.15) != (double)lane) || ((floor / 2) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
