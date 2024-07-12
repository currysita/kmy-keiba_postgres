﻿// <auto-generated />
using System;
using KmyKeiba.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KmyKeiba.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210530121820_AddLearningDataCache")]
    partial class AddLearningDataCache
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("KmyKeiba.Data.Db.ExactaOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber1")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber2")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ExactaOdds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.FrameNumberOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame1")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame2")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FrameNumberOdds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.LearningDataCache", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Cache")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CacheVersion")
                        .HasColumnType("int");

                    b.Property<string>("HorseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("LearningDataCaches");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.QuinellaOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber1")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber2")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("QuinellaOdds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.QuinellaPlaceOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber1")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber2")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("PlaceOddsMax")
                        .HasColumnType("float");

                    b.Property<float>("PlaceOddsMin")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("QuinellaPlaceOdds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.RaceData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("Course")
                        .HasColumnType("smallint");

                    b.Property<int>("CourseRaceNumber")
                        .HasColumnType("int");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("HorsesCount")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name6Chars")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SubjectAge2")
                        .HasColumnType("int");

                    b.Property<int>("SubjectAge3")
                        .HasColumnType("int");

                    b.Property<int>("SubjectAge4")
                        .HasColumnType("int");

                    b.Property<int>("SubjectAge5")
                        .HasColumnType("int");

                    b.Property<int>("SubjectAgeYounger")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("TrackCondition")
                        .HasColumnType("smallint");

                    b.Property<short>("TrackCornerDirection")
                        .HasColumnType("smallint");

                    b.Property<short>("TrackGround")
                        .HasColumnType("smallint");

                    b.Property<short>("TrackOption")
                        .HasColumnType("smallint");

                    b.Property<short>("TrackType")
                        .HasColumnType("smallint");

                    b.Property<short>("TrackWeather")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.RaceHorseData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("AbnormalResult")
                        .HasColumnType("smallint");

                    b.Property<TimeSpan>("AfterThirdHalongTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("AfterThirdHalongTimeOrder")
                        .HasColumnType("int");

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<short>("Course")
                        .HasColumnType("smallint")
                        .HasColumnName("CourseCode");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<int>("FirstCornerOrder")
                        .HasColumnType("int");

                    b.Property<int>("FourthCornerOrder")
                        .HasColumnType("int");

                    b.Property<int>("FrameNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlinkers")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRunningStyleSetManually")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<short>("Mark")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<float>("PlaceOddsMax")
                        .HasColumnType("float");

                    b.Property<float>("PlaceOddsMin")
                        .HasColumnType("float");

                    b.Property<int>("Popular")
                        .HasColumnType("int");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ResultOrder")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ResultTime")
                        .HasColumnType("time(6)");

                    b.Property<string>("RiderCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RiderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("RiderWeight")
                        .HasColumnType("float");

                    b.Property<short>("RunningStyle")
                        .HasColumnType("smallint");

                    b.Property<int>("SecondCornerOrder")
                        .HasColumnType("int");

                    b.Property<short>("Sex")
                        .HasColumnType("smallint");

                    b.Property<int>("ThirdCornerOrder")
                        .HasColumnType("int");

                    b.Property<string>("UniformFormat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("UniformFormatData")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("VARBINARY(8000)");

                    b.Property<short>("Weight")
                        .HasColumnType("smallint");

                    b.Property<short>("WeightDiff")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("RaceHorses");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.RefundData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Exacta2Number3")
                        .HasColumnType("smallint");

                    b.Property<int>("ExactaNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("ExactaNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("ExactaNumber3Money")
                        .HasColumnType("int");

                    b.Property<short>("Frame1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Frame2Number3")
                        .HasColumnType("smallint");

                    b.Property<int>("FrameNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("FrameNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("FrameNumber3Money")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<short>("PlaceNumber1")
                        .HasColumnType("smallint");

                    b.Property<int>("PlaceNumber1Money")
                        .HasColumnType("int");

                    b.Property<short>("PlaceNumber2")
                        .HasColumnType("smallint");

                    b.Property<int>("PlaceNumber2Money")
                        .HasColumnType("int");

                    b.Property<short>("PlaceNumber3")
                        .HasColumnType("smallint");

                    b.Property<int>("PlaceNumber3Money")
                        .HasColumnType("int");

                    b.Property<short>("PlaceNumber4")
                        .HasColumnType("smallint");

                    b.Property<int>("PlaceNumber4Money")
                        .HasColumnType("int");

                    b.Property<short>("PlaceNumber5")
                        .HasColumnType("smallint");

                    b.Property<int>("PlaceNumber5Money")
                        .HasColumnType("int");

                    b.Property<short>("Quinella1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Quinella1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Quinella1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Quinella2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Quinella2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Quinella2Number3")
                        .HasColumnType("smallint");

                    b.Property<int>("QuinellaNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaNumber3Money")
                        .HasColumnType("int");

                    b.Property<short>("QuinellaPlace1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number4")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number5")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number6")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace1Number7")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number4")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number5")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number6")
                        .HasColumnType("smallint");

                    b.Property<short>("QuinellaPlace2Number7")
                        .HasColumnType("smallint");

                    b.Property<int>("QuinellaPlaceNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber3Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber4Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber5Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber6Money")
                        .HasColumnType("int");

                    b.Property<int>("QuinellaPlaceNumber7Money")
                        .HasColumnType("int");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("SingleNumber1")
                        .HasColumnType("smallint");

                    b.Property<int>("SingleNumber1Money")
                        .HasColumnType("int");

                    b.Property<short>("SingleNumber2")
                        .HasColumnType("smallint");

                    b.Property<int>("SingleNumber2Money")
                        .HasColumnType("int");

                    b.Property<short>("SingleNumber3")
                        .HasColumnType("smallint");

                    b.Property<int>("SingleNumber3Money")
                        .HasColumnType("int");

                    b.Property<short>("Trifecta1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta1Number4")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta1Number5")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta1Number6")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number4")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number5")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta2Number6")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number4")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number5")
                        .HasColumnType("smallint");

                    b.Property<short>("Trifecta3Number6")
                        .HasColumnType("smallint");

                    b.Property<int>("TrifectaNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("TrifectaNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("TrifectaNumber3Money")
                        .HasColumnType("int");

                    b.Property<int>("TrifectaNumber4Money")
                        .HasColumnType("int");

                    b.Property<int>("TrifectaNumber5Money")
                        .HasColumnType("int");

                    b.Property<int>("TrifectaNumber6Money")
                        .HasColumnType("int");

                    b.Property<short>("Trio1Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio1Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio1Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio2Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio2Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio2Number3")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio3Number1")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio3Number2")
                        .HasColumnType("smallint");

                    b.Property<short>("Trio3Number3")
                        .HasColumnType("smallint");

                    b.Property<int>("TrioNumber1Money")
                        .HasColumnType("int");

                    b.Property<int>("TrioNumber2Money")
                        .HasColumnType("int");

                    b.Property<int>("TrioNumber3Money")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Refunds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.SystemData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SystemData");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.TrifectaOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber1")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber2")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber3")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TrifectaOdds");
                });

            modelBuilder.Entity("KmyKeiba.Data.Db.TrioOddsData", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<short>("DataStatus")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber1")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber2")
                        .HasColumnType("smallint");

                    b.Property<short>("HorseNumber3")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Odds")
                        .HasColumnType("float");

                    b.Property<string>("RaceKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TrioOdds");
                });
#pragma warning restore 612, 618
        }
    }
}
