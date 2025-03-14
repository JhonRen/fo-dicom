﻿
// Copyright (c) 2012-2021 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace FellowOakDicom
{

    public partial class DicomAnonymizer
    {

        public partial class SecurityProfile
        {
            /// <summary>
            /// De-identification map taken from DICOM PS 3.15: http://dicom.nema.org/medical/dicom/current/output/chtml/part15/PS3.15.html
            /// </summary>
            /// <remarks>
            /// The CSV columns are:
            /// - Tag (regex)
            /// - BasicProfile
            /// - RetainSafePrivateOption
            /// - RetainUIDsOption
            /// - RetainDeviceIdentOption
            /// - RetainPatientCharsOption
            /// - RetainLongFullDatesOption
            /// - RetainLongModifDatesOption
            /// - CleanDescOption
            /// - CleanStructdContOption
            /// - CleanGraphOption
            /// </remarks>
            private const string DefaultProfile = @"
                [0-9A-F]{3}[13579BDF],[0-9A-F]{4};X;C;;;;;;;;
                50[0-9A-F]{2},[0-9A-F]{4};X;;;;;;;;;C
                60[0-9A-F]{2},4000;X;;;;;;;;;C
                60[0-9A-F]{2},3000;X;;;;;;;;;C                
				0008,0050;Z;;;;;;;;;
				0018,4000;X;;;;;;;;C;
				0040,0555;X/Z;;;;;;;;;C
				0008,0022;X/Z;;;;;;K;C;;
				0008,002A;X/Z/D;;;;;;K;C;;
				0018,1400;X/D;;;;;;;;C;
				0018,11BB;D;;;;;;;;C;
				0018,9424;X;;;;;;;;C;
				0008,0032;X/Z;;;;;;K;C;;
				0040,4035;X;;;;;;;;;
				0010,21B0;X;;;;;;;;C;
				0040,A353;X;;;;;;;;;
				0038,0010;X;;;;;;;;;
				0038,0020;X;;;;;;K;C;;
				0008,1084;X;;;;;;;;C;
				0008,1080;X;;;;;;;;C;
				0038,0021;X;;;;;;K;C;;
				0000,1000;X;;K;;;;;;;
				0010,2110;X;;;;;C;;;C;
				4000,0010;X;;;;;;;;;
				0040,A078;X;;;;;;;;;
				2200,0005;X/Z;;;;;;;;;
				300A,00C3;X;;;;;;;;C;
				300A,00DD;X;;;;;;;;C;
				0010,1081;X;;;;;;;;;
				0016,004D;X;;;;;;;;;
				0018,1007;X;;;K;;;;;;
				0012,0060;Z;;;;K;;;;;
				0012,0082;X;;;;;;;;;
				0012,0081;D;;;;K;;;;;
				0012,0020;D;;;;;;;;;
				0012,0021;Z;;;;;;;;;
				0012,0072;X;;;;;;;;C;
				0012,0071;X;;;;;;;;;
				0012,0030;Z;;;;K;;;;;
				0012,0031;Z;;;;K;;;;;
				0012,0010;D;;;;;;;;;
				0012,0040;D;;;;;;;;;
				0012,0042;D;;;;;;;;;
				0012,0051;X;;;;;;;;C;
				0012,0050;Z;;;;;;;;;
				0040,0310;X;;;;;;;;C;
				0040,0280;X;;;;;;;;C;
				300A,02EB;X;;;;;;;;C;
				0020,9161;U;;K;;;;;;;
				3010,000F;Z;;;;;;;;C;
				3010,0017;Z;;;;;;;;C;
				3010,0006;U;;K;;;;;;;
				0040,3001;X;;;;;;;;;
				3010,0013;U;;K;;;;;;;
				0008,009C;Z;;;;;;;;;
				0008,009D;X;;;;;;;;;
				0050,001B;X;;;;;;;;;
				0040,051A;X;;;;;;;;C;
				0040,0512;D;;;;;;;;;
				0070,0086;X;;;;;;;;;
				0070,0084;Z/D;;;;;;;;;
				0008,0023;Z/D;;;;;;K;C;;
				0040,A730;D;;;;;;;;;C
				0008,0033;Z/D;;;;;;K;C;;
				0018,0010;Z/D;;;;;;;;C;
				0018,A003;X;;;;;;;;C;
				0010,2150;X;;;;;;;;;
				0040,A307;X;;;;;;;;;
				0038,0300;X;;;;;;;;;
				0008,0025;X;;;;;;K;C;;
				0008,0035;X;;;;;;K;C;;
				0040,A07C;X;;;;;;;;;
				FFFC,FFFC;X;;;;;;;;;
				0018,937F;X;;;;;;;;C;
				0008,2111;X;;;;;;;;C;
				0018,700A;X/D;;;K;;;;;;
				3010,001B;Z;;;;;;;;;
				0050,0020;X;;;K;;;;;;
				3010,002D;D;;;K;;;;;;
				0018,1000;X/Z/D;;;K;;;;;;
				0016,004B;X;;;;;;;;C;
				0018,1002;U;;K;K;;;;;;
				FFFA,FFFA;X;;;;;;;;;
				0400,0100;U;;;;;;;;;
				0020,9164;U;;K;;;;;;;
				0038,0040;X;;;;;;;;C;
				4008,011A;X;;;;;;;;;
				4008,0119;X;;;;;;;;;
				300A,0016;X;;;;;;;;C;
				300A,0013;U;;K;;;;;;;
				3010,006E;U;;K;;;;;;;
				0018,9517;X/D;;;;;;K;C;;
				3010,0037;X;;;;;;;;C;
				3010,0035;D;;;;;;;;C;
				3010,0038;D;;;;;;;;C;
				3010,0036;X;;;;;;;;C;
				300A,0676;X;;;;;;;;C;
				0010,2160;X;;;;;K;;;;
				0040,4011;X;;;;;;K;C;;
				0008,0058;U;;K;;;;;;;
				0070,031A;U;;K;;;;;;;
				0040,2017;Z;;;;;;;;;
				3008,0054;X/D;;;;;;K;C;;
				300A,0196;X;;;;;;;;C;
				0034,0002;D;;;;;;;;;
				0034,0001;D;;;;;;;;;
				3010,007F;Z;;;;;;;;C;
				300A,0072;X;;;;;;;;C;
				0020,9158;X;;;;;;;;C;
				0020,0052;U;;K;;;;;;;
				0034,0007;D;;;;;;K;C;;
				0018,1008;X;;;K;;;;;;
				0018,1005;X;;;K;;;;;;
				0016,0076;X;;;;;;;;;
				0016,0075;X;;;;;;;;;
				0016,008C;X;;;;;;;;;
				0016,008D;X;;;;;;K;C;;
				0016,0088;X;;;;;;;;;
				0016,0087;X;;;;;;;;;
				0016,008A;X;;;;;;;;;
				0016,0089;X;;;;;;;;;
				0016,0084;X;;;;;;;;;
				0016,0083;X;;;;;;;;;
				0016,0086;X;;;;;;;;;
				0016,0085;X;;;;;;;;;
				0016,008E;X;;;;;;;;;
				0016,007B;X;;;;;;;;;
				0016,0081;X;;;;;;;;;
				0016,0080;X;;;;;;;;;
				0016,0072;X;;;;;;;;;
				0016,0071;X;;;;;;;;;
				0016,0074;X;;;;;;;;;
				0016,0073;X;;;;;;;;;
				0016,0082;X;;;;;;;;;
				0016,007A;X;;;;;;;;;
				0016,008B;X;;;;;;;;;
				0016,0078;X;;;;;;;;;
				0016,007D;X;;;;;;;;;
				0016,007C;X;;;;;;;;;
				0016,0079;X;;;;;;;;;
				0016,0077;X;;;;;;;;;
				0016,007F;X;;;;;;;;;
				0016,007E;X;;;;;;;;;
				0016,0070;X;;;;;;;;;
				0070,0001;D;;;;;;;;;
				0040,4037;X;;;;;;;;;
				0040,4036;X;;;;;;;;;
				0088,0200;X;;;;;;;;;
				0008,4000;X;;;;;;;;C;
				0020,4000;X;;;;;;;;C;
				0028,4000;X;;;;;;;;;
				0040,2400;X;;;;;;;;C;
				003A,0314;D;;;;;;K;C;;
				4008,0300;X;;;;;;;;C;
				0008,0015;X;;;;;;K;C;;
				0008,0014;U;;K;;;;;;;
				0400,0600;X;;;;;;;;;
				0008,0081;X;;;;K;;;;;
				0008,1040;X;;;;K;;;;;
				0008,1041;X;;;;K;;;;;
				0008,0082;X/Z/D;;;;K;;;;;
				0008,0080;X/Z/D;;;;K;;;;;
				0010,1050;X;;;;;;;;;
				3010,004D;X/D;;;;;;K;C;;
				3010,004C;X/D;;;;;;K;C;;
				0040,1011;X;;;;;;;;;
				300A,0741;D;;;;;;K;C;;
				300A,0742;D;;;;;;;;C;
				300A,0783;D;;;;;;;;C;
				4008,0111;X;;;;;;;;;
				4008,010C;X;;;;;;;;;
				4008,0115;X;;;;;;;;C;
				4008,0202;X;;;;;;;;;
				4008,0102;X;;;;;;;;;
				4008,010B;X;;;;;;;;C;
				4008,010A;X;;;;;;;;;
				0008,3010;U;;K;;;;;;;
				0038,0011;X;;;;;;;;;
				0038,0014;X;;;;;;;;;
				0010,0021;X;;;;;;;;;
				0038,0061;X;;;;;;;;;
				0038,0064;X;;;;;;;;;
				0040,0513;Z;;;;;;;;;
				0040,0562;Z;;;;;;;;;
				2200,0002;X/Z;;;;;;;;C;
				0028,1214;U;;K;;;;;;;
				0010,21D0;X;;;;;;K;C;;
				0016,004F;X;;;K;;;;;;
				0016,0050;X;;;K;;;;;;
				0016,0051;X;;;K;;;;;;
				0016,004E;X;;;K;;;;;;
				0050,0021;X;;;;;;;;C;
				0400,0404;X;;;;;;;;;
				0016,002B;X;;;;;;;;C;
				0018,100B;U;;K;K;;;;;;
				3010,0043;Z;;;K;;;;;;
				0002,0003;U;;K;;;;;;;
				0010,2000;X;;;;;;;;C;
				0010,1090;X;;;;;;;;;
				0010,1080;X;;;;;;;;;
				0400,0550;X;;;;;;;;;
				0020,3406;X;;;;;;;;;
				0020,3401;X;;;;;;;;;
				3008,0056;X/D;;;;;;K;C;;
				0018,937B;X;;;;;;;;C;
				003A,0310;U;;K;;;;;;;
				0008,1060;X;;;;;;;;;
				0040,1010;X;;;;;;;;;
				0400,0551;X;;;;;;;;;
				0400,0552;X;;;;;;;;;
				0040,A192;X;;;;;;K;C;;
				0040,A402;U;;K;;;;;;;
				0040,A193;X;;;;;;K;C;;
				0040,A171;U;;K;;;;;;;
				0010,2180;X;;;;;;;;C;
				0008,1072;X/D;;;;;;;;;
				0008,1070;X/Z/D;;;;;;;;;
				0040,2010;X;;;;;;;;;
				0040,2011;X;;;;;;;;;
				0040,2008;X;;;;;;;;;
				0040,2009;X;;;;;;;;;
				0400,0561;X;;;;;;;;;
				0010,1000;X;;;;;;;;;
				0010,1002;X;;;;;;;;;
				0010,1001;X;;;;;;;;;
				0008,0024;X;;;;;;K;C;;
				0008,0034;X;;;;;;K;C;;
				300A,0760;D;;;;;;K;C;;
				0028,1199;U;;K;;;;;;;
				0040,A07A;X;;;;;;;;;
				0010,1040;X;;;;;;;;;
				0010,1010;X;;;;;K;;;;
				0010,0030;Z;;;;;;;;;
				0010,1005;X;;;;;;;;;
				0010,0032;X;;;;;;;;;
				0038,0400;X;;;;;;;;;
				0010,0050;X;;;;;;;;;
				0010,1060;X;;;;;;;;;
				0010,0010;Z;;;;;;;;;
				0010,0101;X;;;;;;;;;
				0010,0102;X;;;;;;;;;
				0010,21F0;X;;;;;;;;;
				0010,0040;Z;;;;;K;;;;
				0010,2203;X/Z;;;;;K;;;;
				0010,1020;X;;;;;K;;;;
				0010,2155;X;;;;;;;;;
				0010,2154;X;;;;;;;;;
				0010,1030;X;;;;;K;;;;
				0010,4000;X;;;;;;;;C;
				0010,0020;Z;;;;;;;;;
				300A,0650;U;;K;;;;;;;
				0038,0500;X;;;;;C;;;C;
				0040,1004;X;;;;;;;;;
				0040,0243;X;;;;;;;;;
				0040,0254;X;;;;;;;;C;
				0040,0250;X;;;;;;K;C;;
				0040,4051;X;;;;;;K;C;;
				0040,0251;X;;;;;;K;C;;
				0040,0253;X;;;;;;;;;
				0040,0244;X;;;;;;K;C;;
				0040,4050;X;;;;;;K;C;;
				0040,0245;X;;;;;;K;C;;
				0040,0241;X;;;K;;;;;;
				0040,4030;X;;;K;;;;;;
				0040,0242;X;;;K;;;;;;
				0040,4028;X;;;K;;;;;;
				0008,1050;X;;;;;;;;;
				0008,1052;X;;;;;;;;;
				0040,1102;X;;;;;;;;;
				0040,1104;X;;;;;;;;;
				0040,1103;X;;;;;;;;;
				0040,1101;D;;;;;;;;;
				0040,A123;D;;;;;;;;;
				0008,1048;X;;;;;;;;;
				0008,1049;X;;;;;;;;;
				0008,1062;X;;;;;;;;;
				4008,0114;X;;;;;;;;;
				0040,2016;Z;;;;;;;;;
				0018,1004;X;;;K;;;;;;
				0010,21C0;X;;;;;K;;;;
				0040,0012;X;;;;;C;;;;
				300A,000E;X;;;;;;;;C;
				3010,007B;Z;;;;;;;;C;
				3010,0081;Z;;;;;;;;C;
				0070,1101;U;;K;;;;;;;
				0070,1102;U;;K;;;;;;;
				3010,0061;X;;;;;;;;C;
				0040,4052;X;;;;;;K;C;;
				0018,1030;X/D;;;;;;;;C;
				300A,0619;D;;;;;;;;C;
				300A,0623;D;;;;;;;;C;
				300A,067D;Z;;;;;;;;C;
				300A,067C;D;;;;;;;;C;
				300C,0113;X;;;;;;;;C;
				0040,100A;X;;;;;;;;C;
				0032,1030;X;;;;;;;;C;
				3010,005C;Z;;;;;;;;C;
				0040,2001;X;;;;;;;;C;
				0040,1002;X;;;;;;;;C;
				0032,1066;X;;;;;;;;C;
				0032,1067;X;;;;;;;;C;
				300A,073A;D;;;;;;K;C;;
				3010,000B;U;;K;;;;;;;
				0400,0402;X;;;;;;;;;
				300A,0083;U;;K;;;;;;;
				3010,006F;U;;K;;;;;;;
				3010,0031;U;;K;;;;;;;
				3006,0024;U;;K;;;;;;;
				0040,4023;U;;K;;;;;;;
				0008,1140;X/Z/U*;;K;;;;;;;
				0040,A172;U;;K;;;;;;;
				0038,0004;X;;;;;;;;;
				0010,1100;X;;;;;;;;;
				0008,1120;X;;X;;;;;;;
				0008,1111;X/Z/D;;K;;;;;;;
				0400,0403;X;;;;;;;;;
				0008,1155;U;;K;;;;;;;
				0004,1511;U;;K;;;;;;;
				0008,1110;X/Z;;K;;;;;;;
				0008,0092;X;;;;;;;;;
				0008,0090;Z;;;;;;;;;
				0008,0094;X;;;;;;;;;
				0008,0096;X;;;;;;;;;
				0010,2152;X;;;;;;;;;
				3006,00C2;U;;K;;;;;;;
				0040,0275;X;;;;;;;;C;
				0032,1070;X;;;;;;;;C;
				0040,1400;X;;;;;;;;C;
				0032,1060;X/Z;;;;;;;;C;
				0040,1001;X;;;;;;;;;
				0040,1005;X;;;;;;;;;
				0018,9937;X;;;;;;;;C;
				0000,1001;U;;K;;;;;;;
				0032,1032;X;;;;;;;;;
				0032,1033;X;;;;;;;;;
				0018,9185;X;;;;;;;;C;
				0010,2299;X;;;;;;;;;
				0010,2297;X;;;;;;;;;
				4008,4000;X;;;;;;;;C;
				4008,0118;X;;;;;;;;;
				4008,0042;X;;;;;;;;;
				300E,0008;X/Z;;;;;;;;;
				3006,0028;X;;;;;;;;C;
				3006,0038;X;;;;;;;;C;
				3006,00A6;Z;;;;;;;;;
				3006,0026;Z;;;;;;;;C;
				3006,0088;X;;;;;;;;C;
				3006,0085;X;;;;;;;;C;
				300A,0615;Z;;;;;;;;;
				300A,0611;Z;;;;;;;;;
				3010,005A;Z;;;;;;;;C;
				300A,0006;X/D;;;;;;K;C;;
				300A,0004;X;;;;;;;;C;
				300A,0002;D;;;;;;;;C;
				300A,0003;X;;;;;;;;C;
				300A,0007;X/D;;;;;;K;C;;
				3010,0054;D;;;;;;;;C;
				300A,062A;D;;;;;;;;C;
				3010,0056;X/D;;;;;;;;C;
				3010,003B;U;;K;;;;;;;
				0040,4034;X;;;;;;;;;
				0038,001E;X;;;;;;;;;
				0040,0006;X;;;;;;;;;
				0040,000B;X;;;;;;;;;
				0040,0007;X;;;;;;;;C;
				0040,0004;X;;;;;;K;C;;
				0040,0005;X;;;;;;K;C;;
				0040,4008;X;;;;;;K;C;;
				0040,0009;X;;;;;;;;;
				0040,0011;X;;;K;;;;;;
				0040,4010;X;;;;;;K;C;;
				0040,0002;X;;;;;;K;C;;
				0040,4005;X;;;;;;K;C;;
				0040,0003;X;;;;;;K;C;;
				0040,0001;X;;;K;;;;;;
				0040,4027;X;;;K;;;;;;
				0040,0010;X;;;K;;;;;;
				0040,4025;X;;;K;;;;;;
				0032,1020;X;;;K;;;;;;
				0032,1021;X;;;K;;;;;;
				0008,0021;X/D;;;;;;K;C;;
				0008,103E;X;;;;;;;;C;
				0020,000E;U;;K;;;;;;;
				0008,0031;X/D;;;;;;K;C;;
				0038,0062;X;;;;;;;;C;
				0038,0060;X;;;;;;;;;
				300A,01B2;X;;;;;;;;C;
				300A,01A6;X;;;;;;;;C;
				0040,06FA;X;;;;;;;;;
				0010,21A0;X;;;;;K;;;;
				0008,0018;U;;K;;;;;;;
				3010,0015;U;;K;;;;;;;
				0018,936A;D;;;;;;K;C;;
				0034,0005;D;;;;;;;;;
				0008,2112;X/Z/U*;;K;;;;;;;
				300A,0216;X;;;K;;;;;;
				3008,0105;X/Z;;;K;;;;;;
				0018,9369;D;;;;;;K;C;;
				0038,0050;X;;;;;C;;;;
				0040,050A;X;;;;;;;;;
				0040,0602;X;;;;;;;;C;
				0040,0551;D;;;;;;;;;
				0040,0610;Z;;;;;;;;;C
				0040,0600;X;;;;;;;;C;
				0040,0554;U;;K;;;;;;;
				0018,9516;X/D;;;;;;K;C;;
				0008,1010;X/Z/D;;;K;;;;;;
				0088,0140;U;;K;;;;;;;
				3006,0008;Z;;;;;;K;C;;
				3006,0006;X;;;;;;;;C;
				3006,0002;D;;;;;;;;C;
				3006,0004;X;;;;;;;;C;
				3006,0009;Z;;;;;;K;C;;
				0032,4000;X;;;;;;;;C;
				0008,0020;Z;;;;;;K;C;;
				0008,1030;X;;;;;;;;C;
				0020,0010;Z;;;;;;;;;
				0032,0012;X;;;;;;;;;
				0020,000D;U;;K;;;;;;;
				0008,0030;Z;;;;;;K;C;;
				0020,0200;U;;K;;;;;;;
				0018,2042;U;;K;;;;;;;
				0040,A354;X;;;;;;;;;
				0040,DB0D;U;;K;;;;;;;
				0040,DB0C;U;;K;;;;;;;
				4000,4000;X;;;;;;;;;
				2030,0020;X;;;;;;;;;
				0008,0201;X;;;;;;K;C;;
				0088,0910;X;;;;;;;;;
				0088,0912;X;;;;;;;;;
				0088,0906;X;;;;;;;;;
				0088,0904;X;;;;;;;;;
				0062,0021;U;;K;;;;;;;
				0008,1195;U;;K;;;;;;;
				0018,5011;X;;;K;;;;;;
				3008,0250;X/D;;;;;;K;C;;
				300A,00B2;X/Z;;;K;;;;;;
				300A,0608;D;;;;;;;;C;
				300A,0609;U;;K;;;;;;;
				300A,0700;U;;K;;;;;;;
				3010,0077;D;;;;;;;;C;
				3010,007A;Z;;;;;;;;C;
				3008,0251;X/D;;;;;;K;C;;
				300A,0736;D;;;;;;K;C;;
				300A,0734;D;;;;;;;;C;
				0018,100A;X;;;K;;;;;;
				0040,A124;U;;;;;;;;;
				0018,1009;X;;;K;;;;;;
				3010,0033;D;;;;;;;;C;
				3010,0034;D;;;;;;;;C;
				0040,A352;X;;;;;;;;;
				0040,A358;X;;;;;;;;;
				0040,A088;Z;;;;;;;;;
				0040,A075;D;;;;;;;;;
				0040,A073;D;;;;;;;;;
				0040,A027;D;;;;;;;;;
				0038,4000;X;;;;;;;;C;
				0018,9371;D;;;K;;;;;;
				0018,9373;X;;;K;;;;;;
				0018,9367;D;;;K;;;;;;
			";
        }
    }
}
