﻿using AIS.API.Validators.QuestionIntervieweeAnswer;
using AIS.API.Validators.QuestionSet;
using AIS.API.ViewModels.QuestionSet;
using Shouldly;
using Xunit;

namespace AIS.API.Tests.Validators.QuestionSet
{
    public class QuestionSetAddViewModelValidatorTests
    {
        [Fact]
        public void Validate_ValidModel_ReturnsTrue()
        {
            var validator = new QuestionSetAddViewModelValidator();
            var model = new QuestionSetAddViewModel
            {
                Name = "Okay",
            };

            // Act
            var result = validator.Validate(model);

            // Assert
            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public void Validate_WithoutName_ReturnsFalse()
        {
            var validator = new QuestionSetAddViewModelValidator();
            var model = new QuestionSetAddViewModel
            {
            };

            // Act
            var result = validator.Validate(model);

            // Assert
            result.Errors.ShouldNotBeEmpty();
            result.Errors.ShouldContain(x => x.PropertyName == nameof(model.Name));
        }

        [Fact]
        public void Validate_NameLengthLessThanTwo_ReturnsFalse()
        {
            var validator = new QuestionSetAddViewModelValidator();
            var model = new QuestionSetAddViewModel
            {
                Name = "A"
            };

            // Act
            var result = validator.Validate(model);

            // Assert
            result.Errors.ShouldNotBeEmpty();
            result.Errors.ShouldContain(x => x.PropertyName == nameof(model.Name));
        }
    }
}
