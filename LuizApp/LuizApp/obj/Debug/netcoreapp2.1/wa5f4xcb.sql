CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Quizzes" (
    "QuizID" integer NOT NULL,
    "Name" text NULL,
    "Creator" text NULL,
    "PCCS" boolean NOT NULL,
    CONSTRAINT "PK_Quizzes" PRIMARY KEY ("QuizID")
);

CREATE TABLE "Questions" (
    "QuestionID" integer NOT NULL,
    "QuizID" integer NOT NULL,
    "QuestionName" character varying(200) NULL,
    "Question1" text NULL,
    "Question2" text NULL,
    "Question3" text NULL,
    "Question4" text NULL,
    "CorrectAnswer" integer NOT NULL,
    CONSTRAINT "PK_Questions" PRIMARY KEY ("QuestionID"),
    CONSTRAINT "FK_Questions_Quizzes_QuizID" FOREIGN KEY ("QuizID") REFERENCES "Quizzes" ("QuizID") ON DELETE CASCADE
);

CREATE INDEX "IX_Questions_QuizID" ON "Questions" ("QuizID");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200207231558_Initial', '2.1.14-servicing-32113');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200227223703_Test', '2.1.14-servicing-32113');

