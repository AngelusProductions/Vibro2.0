﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vibro.API1.Data;

#nullable disable

namespace Vibro.API1.Migrations
{
    [DbContext(typeof(VibroDbContext))]
    [Migration("20240410001917_Adding Images Table")]
    partial class AddingImagesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vibro.API.Models.Idea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MixId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Timestamp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MixId");

                    b.ToTable("Ideas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ca04137-4779-4902-a925-1111ab77adcd"),
                            Description = "Maybe add a bassoon sound here",
                            MixId = new Guid("54ef1bf7-6668-4f13-ab65-0efe55bbfd72"),
                            Name = "Bassoon Noise",
                            Timestamp = 33
                        },
                        new
                        {
                            Id = new Guid("9d65cc87-87a5-4e5d-b063-16b69f7ebfb0"),
                            Description = "That bass synth sounds best here",
                            MixId = new Guid("9d65cc87-87a5-4e5d-b063-16b69f7ebfb0"),
                            Name = "Bass Note",
                            Timestamp = 3
                        },
                        new
                        {
                            Id = new Guid("6444ddd9-6e84-4057-a397-5151d70f02a6"),
                            Description = "Your vox sound great",
                            MixId = new Guid("feda2a99-a2c0-474d-8105-2040abeaa0c6"),
                            Name = "Vocal Compliment",
                            Timestamp = 5
                        },
                        new
                        {
                            Id = new Guid("d83124dd-7377-4478-800f-6ee27ef85a7a"),
                            Description = "Maybe go into a bridge here",
                            MixId = new Guid("7023c09e-bc53-4556-8903-da35c3678f79"),
                            Name = "Bridge Idea",
                            Timestamp = 20
                        },
                        new
                        {
                            Id = new Guid("2c9d8f58-4efc-47de-a76d-8b57bbcd8dd0"),
                            Description = "I think the instruments sound too generic",
                            MixId = new Guid("54ef1bf7-6668-4f13-ab65-0efe55bbfd72"),
                            Name = "Instrument Advice",
                            Timestamp = 0
                        },
                        new
                        {
                            Id = new Guid("e16093d5-225f-4b6c-8eb2-9e6ab2804dfc"),
                            Description = "Maybe you could add a bass drop here",
                            MixId = new Guid("feda2a99-a2c0-474d-8105-2040abeaa0c6"),
                            Name = "Bass Idea",
                            Timestamp = 60
                        },
                        new
                        {
                            Id = new Guid("57cf54e6-92ce-493d-a235-db1287012601"),
                            Description = "This track has a lot of promise",
                            MixId = new Guid("7250216c-7bb1-4faf-891e-ea8999dedd62"),
                            Name = "Great start",
                            Timestamp = 0
                        },
                        new
                        {
                            Id = new Guid("454750b9-f65e-473b-96b2-e67b378bbcd8"),
                            Description = "Her voice sounds the best here",
                            MixId = new Guid("4e8d89e9-4c7b-424e-b561-c67282c99513"),
                            Name = "Nice Voice",
                            Timestamp = 25
                        });
                });

            modelBuilder.Entity("Vibro.API.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Vibro.API.Models.Mix", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Runtime")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VibeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VibeId");

                    b.ToTable("Mixes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("54ef1bf7-6668-4f13-ab65-0efe55bbfd72"),
                            Description = "I substituted the voices for orchestra noises.",
                            Name = "Orchestral Mix",
                            Number = 2,
                            Runtime = 135,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/Dance%20of%20the%20Fancy%20People%20%7C%20Orchestral.wav",
                            VibeId = new Guid("08bd6e52-0af4-4d2e-8ec0-dddadd526e90")
                        },
                        new
                        {
                            Id = new Guid("9d65cc87-87a5-4e5d-b063-16b69f7ebfb0"),
                            Description = "This is the genesis of the idea.",
                            Name = "Original Mix",
                            Number = 1,
                            Runtime = 18,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/Brain%20Dancer.wav",
                            VibeId = new Guid("a89773dc-bd4c-48c7-9041-8b9f912ff596")
                        },
                        new
                        {
                            Id = new Guid("feda2a99-a2c0-474d-8105-2040abeaa0c6"),
                            Description = "Here is the demo I played for Epiphany Space",
                            Name = "Demo",
                            Number = 3,
                            Runtime = 69,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/I'm%20a%20Superhero!%20(Demo).wav",
                            VibeId = new Guid("a89773dc-bd4c-48c7-9041-8b9f912ff596")
                        },
                        new
                        {
                            Id = new Guid("77e8e2a4-140e-4ee2-a4b1-8a7deea39931"),
                            Description = "This is how it initially was created.",
                            Name = "Original Mix",
                            Number = 1,
                            Runtime = 138,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/Dance%20of%20the%20Fancy%20People.wav",
                            VibeId = new Guid("08bd6e52-0af4-4d2e-8ec0-dddadd526e90")
                        },
                        new
                        {
                            Id = new Guid("47665a2a-0015-46e9-bb44-a1fa0191782e"),
                            Description = "Here I extended it into a short track",
                            Name = "More Fleshed Out Mix",
                            Number = 2,
                            Runtime = 50,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/I'm%20a%20Superhero!.wav",
                            VibeId = new Guid("a89773dc-bd4c-48c7-9041-8b9f912ff596")
                        },
                        new
                        {
                            Id = new Guid("4e8d89e9-4c7b-424e-b561-c67282c99513"),
                            Description = "They added their own feel to the groove",
                            Name = "Tay Eb Mix",
                            Number = 2,
                            Runtime = 172,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/Pisces%20Season%20Tay%20demo%20bounce.wav",
                            VibeId = new Guid("0e416981-389e-40ef-a96d-85e277d82b13")
                        },
                        new
                        {
                            Id = new Guid("1c134b6d-327a-4e20-93de-d0948a53a2cf"),
                            Description = "This was written for the L&V soundtrack",
                            Name = "Initial Mix",
                            Number = 1,
                            Runtime = 172,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/Lo-Fi%20Samba%20(03%3A05%3A2024).wav",
                            VibeId = new Guid("0e416981-389e-40ef-a96d-85e277d82b13")
                        },
                        new
                        {
                            Id = new Guid("7023c09e-bc53-4556-8903-da35c3678f79"),
                            Description = "We then turned it into POST THAT SHIT",
                            Name = "Post That Shit Creation",
                            Number = 2,
                            Runtime = 71,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/POST%20THAT%20SHIT!.wav",
                            VibeId = new Guid("a4044506-455e-47b2-a8cf-7dd16d42d182")
                        },
                        new
                        {
                            Id = new Guid("7250216c-7bb1-4faf-891e-ea8999dedd62"),
                            Description = "This is the first go around for this track.",
                            Name = "Original Mix",
                            Number = 1,
                            Runtime = 23,
                            Url = "https://storage.googleapis.com/angelusproductions.com/vibes/mixes/GuardianVideo.wav",
                            VibeId = new Guid("a4044506-455e-47b2-a8cf-7dd16d42d182")
                        });
                });

            modelBuilder.Entity("Vibro.API.Models.Vibe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArtUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vibes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4044506-455e-47b2-a8cf-7dd16d42d182"),
                            ArtUrl = "https://storage.googleapis.com/angelusproductions.com/vibes/art/postThatShit.webp",
                            Description = "A hip-hop beat for those about to post.",
                            Name = "POST THAT SHIT!"
                        },
                        new
                        {
                            Id = new Guid("0e416981-389e-40ef-a96d-85e277d82b13"),
                            ArtUrl = "https://storage.googleapis.com/angelusproductions.com/vibes/art/lofiSamba.webp",
                            Description = "A chill lofi beat with a Latin flavor.",
                            Name = "Lofi Samba"
                        },
                        new
                        {
                            Id = new Guid("a89773dc-bd4c-48c7-9041-8b9f912ff596"),
                            ArtUrl = "https://storage.googleapis.com/angelusproductions.com/vibes/art/bitchImASuperhero.webp",
                            Description = "A fun song about having superpowers.",
                            Name = "Bitch, I'm a Superhero!"
                        },
                        new
                        {
                            Id = new Guid("08bd6e52-0af4-4d2e-8ec0-dddadd526e90"),
                            ArtUrl = "https://storage.googleapis.com/angelusproductions.com/vibes/art/danceOfTheFancyPeople.webp",
                            Description = "This song is only for the fanciest of people.",
                            Name = "Dance of the Fancy People"
                        });
                });

            modelBuilder.Entity("Vibro.API.Models.Idea", b =>
                {
                    b.HasOne("Vibro.API.Models.Mix", "Mix")
                        .WithMany()
                        .HasForeignKey("MixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mix");
                });

            modelBuilder.Entity("Vibro.API.Models.Mix", b =>
                {
                    b.HasOne("Vibro.API.Models.Vibe", "Vibe")
                        .WithMany()
                        .HasForeignKey("VibeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vibe");
                });
#pragma warning restore 612, 618
        }
    }
}
