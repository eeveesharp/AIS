const config = {
    COMPANY_URL: 'api/Company',
    EMPLOYEE_URL: 'api/Employee',
    INTERVIEWEE_URL: 'api/Interviewee',
    QUESTION_URL: 'api/Questions',
    QUESTION_AREA_URL : 'api/QuestionArea',
    QUESTION_INTERVIEWEE_ANSWER_URL: 'api/QuestionIntervieweeAnswer',
    QUESTION_SET_URL : 'api/QuestionSets',
    SESSION_URL : 'api/Session',
    TRUE_ANSWER_URL : 'api/TrueAnswer',
    DELETE_BY_TWO_IDS_QUESTION_AREA : 'api/QuestionAreasQuestionSets/deleteByTwoIds',
    DELETE_BY_TWO_IDS_QUESTION : 'api/QuestionsQuestionSets/deleteByTwoIds'
};

const localConfig = require('./config.local.js').default;
Object.assign(config, localConfig);

export const Config = config;